﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

/*
• DONE: Indexer(this) properties not generated.
• DONE: No constructor generated.
* DONE: No type provided for expressions.
• DONE: Backing fields for auto-generated properties are missing
• SKIPPED: Interpolated string not supported
• DONE: Tuple expressions and tuple assignment 
* DONE: Cast doesn't work.
• Need MathF functions provided. 
• Missing ids on parameter references
• Missing ids of function references
* DONE: Extension functions are translated into member functions. 
* DONE: Get the list of captured variables
* Construcotr returning interface 
* Can't find operator method (need to add "OperationDeclaration")
*/

namespace PlatoGenerator
{
    public class JavaScriptGenerator
    {
        // TODO: symbols? 

        public Dictionary<SyntaxNode, FunctionDefinition> SyntaxToFunctions = new Dictionary<SyntaxNode, FunctionDefinition>();
        public Dictionary<SyntaxNode, PropertyDefinition> SyntaxToProperties = new Dictionary<SyntaxNode, PropertyDefinition>();

        public StreamWriter sw;

        // TODO: catch and deal with recursion.
        //public HashSet<FunctionDefinition> InliningFunction;

        public string LogFileName = Path.Combine(Path.GetTempPath(), "plato.js");

        public string ReduceExpression(Expression expr, bool declareVar = true)
        {
            if (expr.Syntax is AssignmentExpressionSyntax assExpr)
            {
                var children = expr.Children.ToList();
                if (children.Count != 2)
                    throw new Exception("Expected two children");
                var lvalue = children[0];
                var rvalue = ReduceExpression(children[1]);
                if (lvalue.Syntax is TupleExpressionSyntax tupleExpr)
                {
                    // We have multiple parts. 
                    var output = "";
                    for (var i=0; i < tupleExpr.Arguments.Count; ++i)
                    {
                        output += $"{ReduceExpression(lvalue.Arguments[i])} {assExpr.OperatorToken} {rvalue}.Item{i + 1}; ";
                    }
                    return output;
                }

                return $"{ReduceExpression(lvalue)} {assExpr.OperatorToken} {rvalue}";
            }

            var childNames = expr.Children.Select(x => ReduceExpression(x)).ToList();
            var args = string.Join(",", childNames);
            var ds = expr.DeclarationSyntax;
            var dsKind = ds?.Kind().ToString() ?? "unknown declaration syntax";

            // TODO: somehow this isn't always expression syntax. I had a cast and it blew up. 
            var syntax = expr.Syntax;
            switch (syntax)
            {
                case AliasQualifiedNameSyntax aliasQualifiedNameSyntax:
                    break;
                case AnonymousMethodExpressionSyntax anonymousMethodExpressionSyntax:
                    break;
                case AnonymousObjectCreationExpressionSyntax anonymousObjectCreationExpressionSyntax:
                    break;
                case ArrayCreationExpressionSyntax arrayCreationExpressionSyntax:
                    break;
                case ArrayTypeSyntax arrayTypeSyntax:
                    break;
                case AssignmentExpressionSyntax assignmentExpressionSyntax:
                    throw new Exception("Was supposed to be handled earlier in the function");
                case AwaitExpressionSyntax awaitExpressionSyntax:
                    break;
                case BaseExpressionSyntax baseExpressionSyntax:
                    return "base";
                case CastExpressionSyntax castExpressionSyntax:
                    break;
                case CheckedExpressionSyntax checkedExpressionSyntax:
                    break;
                case ConditionalAccessExpressionSyntax conditionalAccessExpressionSyntax:
                    break;
                case DeclarationExpressionSyntax declarationExpressionSyntax:
                    break;
                case DefaultExpressionSyntax defaultExpressionSyntax:
                    return "default";
                case ElementAccessExpressionSyntax elementAccessExpressionSyntax:
                    break;
                case ElementBindingExpressionSyntax elementBindingExpressionSyntax:
                    break;
                case FunctionPointerTypeSyntax functionPointerTypeSyntax:
                    break;
                case GenericNameSyntax genericNameSyntax:
                    break;
                case IdentifierNameSyntax identifierNameSyntax:
                    return identifierNameSyntax.Identifier.ToString();
                case ImplicitArrayCreationExpressionSyntax implicitArrayCreationExpressionSyntax:
                    break;
                case ImplicitElementAccessSyntax implicitElementAccessSyntax:
                    break;
                case ImplicitObjectCreationExpressionSyntax implicitObjectCreationExpressionSyntax:
                {
                    var type = expr.Type;
                    // TODO: get the type ID. I currently don't have the PlatoType.
                    return $"new {type.Name}({args})";
                }

                case ImplicitStackAllocArrayCreationExpressionSyntax implicitStackAllocArrayCreationExpressionSyntax:
                    break;
                case InitializerExpressionSyntax initializerExpressionSyntax:
                    break;
                case InterpolatedStringExpressionSyntax interpolatedStringExpressionSyntax:
                    break;
                case InvocationExpressionSyntax invocationExpressionSyntax:
                    break;
                case IsPatternExpressionSyntax isPatternExpressionSyntax:
                    break;
                case LiteralExpressionSyntax literalExpressionSyntax:
                    return literalExpressionSyntax.ToString();

                case MakeRefExpressionSyntax makeRefExpressionSyntax:
                    break;
                case MemberAccessExpressionSyntax memberAccessExpressionSyntax:
                    if (memberAccessExpressionSyntax.OperatorToken.ToString() != ".")
                        throw new NotImplementedException("Only . access is supported at current time");
                    return $"{childNames.Single()}.{memberAccessExpressionSyntax.Name.Identifier}";
                case MemberBindingExpressionSyntax memberBindingExpressionSyntax:
                    break;
                case NullableTypeSyntax nullableTypeSyntax:
                    break;
                case ObjectCreationExpressionSyntax objectCreationExpressionSyntax:
                    {
                        var type = expr.Type;
                        // TODO: get the type ID. I currently don't have the PlatoType.
                        return $"new {type.Name}({args})";
                    }
                case OmittedArraySizeExpressionSyntax omittedArraySizeExpressionSyntax:
                    break;
                case OmittedTypeArgumentSyntax omittedTypeArgumentSyntax:
                    break;
                case ParenthesizedExpressionSyntax parenthesizedExpressionSyntax:
                    return childNames.Single();
                case ParenthesizedLambdaExpressionSyntax parenthesizedLambdaExpressionSyntax:
                    break;
                case PointerTypeSyntax pointerTypeSyntax:
                    break;
                case PredefinedTypeSyntax predefinedTypeSyntax:
                    break;
                case QualifiedNameSyntax qualifiedNameSyntax:
                    break;
                case QueryExpressionSyntax queryExpressionSyntax:
                    break;
                case RangeExpressionSyntax rangeExpressionSyntax:
                    break;
                case RefExpressionSyntax refExpressionSyntax:
                    break;
                case RefTypeExpressionSyntax refTypeExpressionSyntax:
                    break;
                case RefTypeSyntax refTypeSyntax:
                    break;
                case RefValueExpressionSyntax refValueExpressionSyntax:
                    break;
                case SimpleLambdaExpressionSyntax simpleLambdaExpressionSyntax:
                    break;
                case SizeOfExpressionSyntax sizeOfExpressionSyntax:
                    break;
                case StackAllocArrayCreationExpressionSyntax stackAllocArrayCreationExpressionSyntax:
                    break;
                case SwitchExpressionSyntax switchExpressionSyntax:
                    // TODO: turn this into a Switch statement
                    break;
                case ThisExpressionSyntax thisExpressionSyntax:
                    return "this";
                case ThrowExpressionSyntax throwExpressionSyntax:
                    return $"throw {childNames.FirstOrDefault()}";
                case TupleExpressionSyntax tupleExpressionSyntax:
                    break;
                case TupleTypeSyntax tupleTypeSyntax:
                    break;
                case TypeOfExpressionSyntax typeOfExpressionSyntax:
                    break;
                case WithExpressionSyntax withExpressionSyntax:
                    break;
                case BaseObjectCreationExpressionSyntax baseObjectCreationExpressionSyntax:
                    break;
                case InstanceExpressionSyntax instanceExpressionSyntax:
                    break;
                case LambdaExpressionSyntax lambdaExpressionSyntax:
                    break;
                case SimpleNameSyntax simpleNameSyntax:
                    return simpleNameSyntax.Identifier.ToString();
                case AnonymousFunctionExpressionSyntax anonymousFunctionExpressionSyntax:
                    break;
                case NameSyntax nameSyntax:
                    return nameSyntax.ToString();
                case TypeSyntax typeSyntax:
                    break;
                default:
                    // TODO: when I figure out why expressions have non-expression syntax, reinstate this check. 
                    //throw new ArgumentOutOfRangeException(nameof(syntax));
                    break;
            }

            // TODO: do the same for initializers. 
            var exprVarName = $"var{expr.Id}";
            FunctionDefinition def = null;
            if (ds != null) SyntaxToFunctions.TryGetValue(ds, out def);
            var defText = def != null ? $"{def.Name}@{def.Id}" : "";

            var name = expr.Name;
            if (name == "#at")
            {
                name = "Plato.At";
            }
            else if (name == "#tuple")
            {
                name = "Plato.Tuple";
            }
            else if (name == "#interpolatedstring")
            {
                // Why are there no arguments? 
                //name = "Plato.Format";
                throw new NotImplementedException("TODO");
            }
            else if (name.StartsWith("#cast"))
            {
                name = "Plato.Cast";
                
                // NOTE: maybe this should be a "TypeOf" operation? 
                var typeArg = $"\"{expr.TypeString}\"";

                if (args.Length != 0)
                    args = $"{typeArg}, " + args;
                else
                    args = $"{typeArg}";
            }

            var exprValue = $"{name}({args})";

            if (name.StartsWith("#operator"))
            {
                // TODO: this should go to functions so that we can have operator overloading. 

                switch (expr.Syntax)
                {
                    case ConditionalExpressionSyntax conditionalExpressionSyntax:
                        if (childNames.Count != 3) throw new Exception("Expected three children");
                        exprValue = $"{childNames[0]} ? {childNames[1]} : {childNames[2]}";
                        break;
                    case BinaryExpressionSyntax binaryExpressionSyntax:
                        if (childNames.Count != 2) throw new Exception("Expected two children");
                        exprValue = $"{childNames[0]} {binaryExpressionSyntax.OperatorToken} {childNames[1]}";
                        break;
                    case PostfixUnaryExpressionSyntax postfixUnaryExpressionSyntax:
                        if (childNames.Count != 1) throw new Exception("Expected one child");
                        exprValue = $"{childNames[0]}{postfixUnaryExpressionSyntax.OperatorToken}";
                        break;
                    case PrefixUnaryExpressionSyntax prefixUnaryExpressionSyntax:
                        if (childNames.Count != 1) throw new Exception("Expected one child");
                        exprValue = $"{prefixUnaryExpressionSyntax.OperatorToken}{childNames[0]}";
                        break;
                    default:
                        throw new Exception($"Unrecognized operator {name} : {expr.SyntaxKind}");
                }
            }
            else if (name.StartsWith("#invoke"))
            {
                // TODO: an interesting problem is that when a method is an extension method, we need to pass the "this"
                // I can make a trampoline function maybe? I think no matter what I need to know when I am accessing a method group,
                // and if that method group is known at compile-time I am going to do some things differently. 
                // This touches on one of the problems that I also want to tackle. This system can learn new things about values. 
                // In other-words, I can't just rely on Roslyn to tell me things... if a value can be determined by this tool, it 
                // has to be kept. This is what the result of inlining gives us, and is a key observation of the system. 

                // TODO: this means that I have to come up with a decent intermediate representation that will facilitate the work required. 
                // Good news, is that what this system is doing looks a bit like the system that will create the intermediate representation. 

                if (def != null && def.IsExtension)
                {
                    var pos = childNames[0].LastIndexOf(".");
                    var stripEnding = childNames[0].Substring(0, pos);
                    childNames[0] = stripEnding;

                    var invokeArgList = string.Join(", ", childNames);
                    // TODO: what is the owner type? 
                    // TODO: we have a problem because the first child name is the method resolution, not the actual
                    exprValue = $"{def.Name}_{def.Id}({invokeArgList})";
                }
                else
                {
                    var invokeArgList = string.Join(", ", childNames.Skip(1));
                    exprValue = $"{childNames[0]}({invokeArgList})";
                }
            }
            else if (name.StartsWith("#lambda"))
            {
                var f = (FunctionDefinition)expr;
                var dataFlow = f.Model.AnalyzeDataFlow(f.Syntax);
                var capVars = dataFlow.Captured.Select(sym => sym.Name).ToArray() ?? Array.Empty<string>();

                sw.WriteLine($"// Captured: {string.Join(", ", capVars)}");
                var parameters = string.Join(", ", f.Parameters.Select(p => p.Name));
                sw.WriteLine($"var {exprVarName} = ({parameters}) => ");
                sw.WriteLine("{");
                OutputStatement(f.Body, "  ");
                sw.WriteLine("}");
                
                // NOTE: this returns early, unlike other forms. This is because
                return exprVarName;
            }
            else if (name.StartsWith("#with"))
            {
                throw new Exception("With expressions are not allowed, because records aren't allowed");
            }
            else if (name.StartsWith("#declaration"))
            {
                // TODO: what to do? 
                //Debug.Assert(false);
            }
            else if (name.StartsWith("#interpolatedstring"))
            {
                // 
                // TODO: 
                //Debug.Assert(false);
            }
            else if (name.StartsWith("#"))
            {
                Debug.WriteLine($"Unrecognized type {name}");
                throw new Exception("Unrecognized special syntax");
            }
           
            if (declareVar)
            {
                var declKind = expr.Symbol?.GetDeclaringSyntax()?.Kind();
                sw.WriteLine($"    var {exprVarName} = {exprValue}; // Type={expr.TypeString} Def={defText} Sym={expr.Symbol?.Name}:{expr.Symbol?.Kind} DeclSyn={declKind}");
            }

            return exprVarName;
        }

        public void OutputStatement(PlatoStatementSyntax st, SemanticModel model, string indent = "")
        {
            if (st == null)
                return;

            sw.WriteLine($"{indent}{st.Node.GetType().Name}@{st.Id}");

            //var statementSymbol = model.GetSymbolInfo(st.Node).Symbol;
            //sw.WriteLine($"Has statement symbol {statementSymbol}");

            if (st.ChildExpressions.Count > 0)
            {
                //??
            }

            if (st.ChildStatements.Count > 0)
            {
                sw.WriteLine(indent + "  Statements:");
                foreach (var c in st.ChildStatements)
                {
                    OutputStatement(c, model, indent + "     ");
                }
            }
        }

        public void OutputStatement(Statement statement, string indent = "")
        {
            if (statement == null)
                return;
            switch (statement)
            {
                case BlockStatement blockStatementIr:
                    sw.WriteLine($"{indent}{{");
                    foreach (var s in blockStatementIr.Statements)
                        OutputStatement(s, indent + "  ");
                    sw.WriteLine($"{indent}}}");
                    break;

                case ExpressionStatement expressionStatementIr:
                    sw.WriteLine($"{indent}{ReduceExpression(expressionStatementIr.Expression)};");
                    break;

                case IfStatement ifStatementIr:
                    sw.WriteLine($"{indent}if ({ReduceExpression(ifStatementIr.Condition)})");
                    OutputStatement(ifStatementIr.OnTrue, indent + "  ");
                    
                    if (ifStatementIr.OnFalse != null && !(ifStatementIr.OnFalse is EmptyStatement))
                    {
                        sw.WriteLine($"{indent}else");
                        OutputStatement(ifStatementIr.OnFalse);
                    }
                    break;

                case ReturnStatement returnStatementIr:
                    if (returnStatementIr.Expression == null)
                        sw.WriteLine($"{indent}return;");
                    else
                        sw.WriteLine($"{indent}return {ReduceExpression(returnStatementIr.Expression)};");
                    break;

                case ThrowStatement throwStatementIr:
                    if (throwStatementIr.Expression != null)
                        sw.WriteLine($"{indent}throw {ReduceExpression(throwStatementIr.Expression)}");
                    else
                        sw.WriteLine($"{indent}throw;");
                    break;

                case WhileStatement whileStatementIr:
                    OutputStatement(whileStatementIr.Initialization, indent);
                    var condName = ReduceExpression(whileStatementIr.Condition);
                    sw.WriteLine($"{indent}while ({condName})");
                    sw.WriteLine($"{indent}{{");
                    OutputStatement(whileStatementIr.Body, indent + "  ");
                    OutputStatement(whileStatementIr.Increment, indent + "  ");

                    // This triggers a regeneration of the statements to create the expression
                    sw.WriteLine($"{condName} = {ReduceExpression(whileStatementIr.Condition, false)};");
                    sw.WriteLine($"{indent}}}");
                    break;

                case EmptyStatement _:
                    break;

                case MultiStatement multiStatement:
                    foreach (var st in multiStatement.Statements)
                        OutputStatement(st, indent);
                    break;

                case UnsupportedStatement unsupportedStatementIr:
                    throw new NotSupportedException($"{unsupportedStatementIr.Syntax.Kind()}");

                default:
                    throw new ArgumentOutOfRangeException(nameof(statement));
            }
        }

        public void OutputFunction(FunctionDefinition func, string indent = "")
        {
            var paramList = string.Join(", ", func.Parameters.Select(p => $"{p.Name}_{p.Id} /* :{p.Type} */"));
            var staticKeyword = func.IsStatic ? "static " : "";
            sw.WriteLine($"/* ORIGINAL: ");
            sw.WriteLine(func.Syntax.ToString());
            sw.WriteLine($"*/");
            var name = $"{func.Name}_{func.Id}";
            if (func.Name == "#ctor")
            {
                name = "constructor";
            }
            sw.WriteLine($"{indent}{staticKeyword}{name}({paramList}) // :{func.Result?.Type}");
            sw.WriteLine($"{indent}{{");
            OutputStatement(func.Body, indent + "  ");
            sw.WriteLine($"{indent}}}");
        }

        public void OutputType(PlatoTypeSyntax t, string indent = "")
        {
            sw.WriteLine($"class {t.Name} // {t.Kind}");
            sw.WriteLine("{");
            indent += "  ";
            foreach (var f in t.Fields)
            {
                foreach (var v in f.Variables)
                {
                    var staticKeyword = f.IsStatic ? "static " : "";
                    sw.WriteLine($"{indent}{staticKeyword}{v.Name};");
                }
            }
            
            foreach (var p in t.Properties)
            {
                var staticKeyword = p.IsStatic ? "static " : "";
             

                var pdef = SyntaxToProperties[p.Node];

                if (pdef == null)
                    throw new Exception("Could not find property");

                if (pdef.IsAutoProperty)
                {
                    // It is indistinguishable from a field. 
                    sw.WriteLine($"{indent}{staticKeyword} {p.Name};");
                }
                else
                {
                    sw.WriteLine($"{indent}{staticKeyword}get {p.Name}()");
                    sw.WriteLine($"{indent}{{");
                    OutputStatement(pdef.Getter.Body, indent + "  ");
                    sw.WriteLine($"{indent}}}");
                }
            }

            // A global namespace version of each function and one just on the type? 
            foreach (var c in t.Ctors)
            {
                var func = SyntaxToFunctions[c.Node];
                OutputFunction(func, "  ");
            }

            // A global namespace version of each function and one just on the type? 
            foreach (var m in t.Methods)
            {
                var func = SyntaxToFunctions[m.Node];
                OutputFunction(func, "  ");
            }

            foreach (var op in t.Operators)
            {
                var func = SyntaxToFunctions[op.Node];
                OutputFunction(func, "  ");
            }

            sw.WriteLine("}");
        }

        public void CreateLookups(GeneratorExecutionContext context, IReadOnlyList<PlatoTypeSyntax> types)
        {
            foreach (var t in types)
            {
                var model = context.Compilation.GetSemanticModel(t.Node.SyntaxTree);
                foreach (var m in t.Methods)
                {
                    var func = FunctionDefinition.Create(m.Node, model);
                    SyntaxToFunctions.Add(m.Node, func);
                }

                foreach (var op in t.Operators)
                {
                    var func = FunctionDefinition.Create(op.Node, model);
                    SyntaxToFunctions.Add(op.Node, func);
                }

                foreach (var c in t.Ctors)
                {
                    var func = FunctionDefinition.Create(c.Node, model);
                    SyntaxToFunctions.Add(c.Node, func);
                }

                foreach (var p in t.Properties)
                {
                    // TODO: The problem here is a property is complicated. It can have multiple functions associated with it. 
                    // A getter/init/setter
                    // So the solution is to make these things 
                    var prop = PropertyDefinition.Create(p.Node, model);
                    SyntaxToProperties.Add(p.Node, prop);
                }
            }
        }

        public void ToJavaScript(GeneratorExecutionContext context)
        {
            var types = context.Compilation.SyntaxTrees.GetPlatoTypes();

            CreateLookups(context, types);
           
            using (sw = new StreamWriter(File.Create(LogFileName)))
            {
                foreach (var t in types)
                {
                    OutputType(t);
                }
            }
        }
    }
}
