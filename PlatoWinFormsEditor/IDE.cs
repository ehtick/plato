using System.Diagnostics;
using System.Text;
using Parakeet;
using Parakeet.Demos;
using Parakeet.Demos.Plato;
using PlatoAst;
using static System.Windows.Forms.AxHost;

namespace PlatoWinFormsEditor;

public class IDE
{
    public string Input { get; set; }
    public string Output { get; set; }
    public Compilation Compilation { get; set; }
    public SymbolResolver SymbolResolver { get; } = new ();

    public string ParseTree => Try(() => Compilation?.ParseTree?.ToString());
    public string CstXml => Try(() => Compilation?.CstTree?.ToXml().ToString());
    public string AstXml => Try(() => Compilation?.AstTree?.ToXml());
    public string CSharpAst => Try(() => Compilation?.AstTree?.ToCSharp());
    public string JavaScriptAst => Try(() => Compilation?.AstTree?.ToJavaScript());
    public string AbstractValuesXml => SymbolResolver.TypeDefs.ToXml();

    public IDE()
    {
        var inputFile1 = @"C:\Users\cdigg\git\plato\PlatoStandardLibrary\concepts.plato";
        var inputFile2 = @"C:\Users\cdigg\git\plato\PlatoStandardLibrary\types.plato";
        var inputFile3 = @"C:\Users\cdigg\git\plato\PlatoStandardLibrary\modules.plato";
        var input1 = File.ReadAllText(inputFile1);
        var input2 = File.ReadAllText(inputFile2);
        var input3 = File.ReadAllText(inputFile3);
        Input = input1 + Environment.NewLine + input2 + Environment.NewLine + input3;
        Compilation = Compile(Input);

        /*
        var types = IDE.Compilation.AstTree.GetAllTypes().ToList();

        foreach (var type in types)
        {
            //richTextBoxOutput.AppendText($"{type.Kind} {type.Name.Text} {Environment.NewLine}");
        }

        var lookup = new TypeNames(types);
        foreach (var kv in lookup.Dictionary)
        {
            richTextBoxOutput.AppendText($"{kv.Key}");
            richTextBoxOutput.AppendText(Environment.NewLine);

            var memberNames = kv.Value;

            foreach (var kv2 in memberNames.Members)
            {
                richTextBoxOutput.AppendText($"{kv2.Key} = {kv2.Value.GetType().Name}");
                richTextBoxOutput.AppendText(Environment.NewLine);
            }
        }
        */

        // Get the type
        var types = Compilation.AstTree.GetAllTypes().ToList();
        SymbolResolver.CreateTypeDefs(types);

        var sb = new StringBuilder();
        sb.AppendLine();
        foreach (var t in SymbolResolver.TypeDefs)
        {
            sb.AppendLine($"{t.Kind} {t.Name}");
            foreach (var m in t.Methods)
            {
                sb.AppendLine($"Method {m.Name}");
                var lookup = Semantics.GetParameterReferences(m.Function);
                foreach (var kv in lookup)
                {
                    var refs = string.Join(",", kv.Value);
                    sb.AppendLine($"{kv.Key} = {refs}");
                }
            }
        }

        Output += sb.ToString();
    }

    public string Try(Func<string?> f)
    {
        try
        {
            return f() ?? "";
        }
        catch (Exception e)
        {
            return e.Message;
        };
    }

    public Compilation Compile(string input)
    {
        var c = new Compilation(input, PlatoGrammar.Instance.File, 
            CstNodeFactory.Create, AstFromPlatoCst.Convert);

        var outputBuilder = new StringBuilder();

        outputBuilder.AppendLine(c.Success ? "Compilation Success" : "Compilation Failure");

        var state = c.State;
        if (state != null)
        {
            var curError = 0;
            for (var e = state.LastError; e != null; e = e.Previous)
            {
                outputBuilder.AppendLine($"Error {curError} at {e.LastState}");
                outputBuilder.AppendLine($"failed expected rule {e.Expected}, parent state is {e.ParentState}, message is {e.Message}");
                outputBuilder.AppendLine(e.LastState.CurrentLine);
                outputBuilder.AppendLine(e.LastState.Indicator);
            }

            outputBuilder.AppendLine(c.Message);

            if (!state.AtEnd())
            {
                outputBuilder.AppendLine("Parsing did not reach the end");
            }
        }
        else
        {
            outputBuilder.AppendLine("Parsing failed");
        }

        Output = outputBuilder.ToString();
        return c;
    }
}