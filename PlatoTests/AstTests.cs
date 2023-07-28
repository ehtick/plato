﻿using System.Linq.Expressions;
using Plato.Compiler;

namespace PlatoTests
{
    public class AstTests
    {
        public static string DllPath => typeof(AstTests).Assembly.Location;
        public static string ProjectFolder => Path.Combine(Path.GetDirectoryName(DllPath), "..", "..", "..");
        public static string SolutionFolder => Path.Combine(ProjectFolder, "..");

        public static IEnumerable<AstNode> TestInputAstNodes()
        {
            var k = AstConstant.Create(42);
            var k2 = AstConstant.True;
            var lambda = AstLambda.Create(k);
            var f = AstConstant.Create<Func<int, int>>(x => x * 2);
            var writeFunc = AstConstant.Create<Action<string>>(Console.WriteLine);
            var toStr = AstConstant.Create<Func<object, string>>(x => x.ToString());
            var varDef = AstVarDef.Create("x", AstTypeNode.Create("int"));
            var varAss = AstAssign.Create("x", k);
            var toStrIvk = AstInvoke.Create(toStr, varAss);
            var writeIvk = AstInvoke.Create(writeFunc, toStrIvk);
            var blk = AstBlock.Create(varDef, varAss, writeIvk);
            var loop = AstLoop.Create(AstConstant.True, blk);
            var ivk = AstInvoke.Create(f, k);
            var cond = AstConditional.Create(k2, AstConstant.Create("Hello"), AstConstant.Create("Goodbyte"));

            return new AstNode[]
            {
                k,
                k2,
                lambda,
                f,
                writeFunc,
                toStr,
                varDef,
                varAss,
                toStrIvk,
                writeIvk,
                blk,
                loop,
                ivk,
                cond,
            };
        }

        public static int MultiplyBy3(int x)
        {
            return x * 3;
        }

        public class X
        {
            public int Y { get; set; }
        }

        public static Expression<Func<int, int, int>> BinaryIntFuncs(int n)
        {
            var tmp = new X();
            Func<int, int> f = (x => x * 2);
            switch (n)
            {
                case 0: return (a, b) => a + b;
                case 1: return (a, b) => (a * 2) + (b * 3);
                case 2: return (a, b) => f(a) + b;
                case 3: return (a, b) => MultiplyBy3(a) + MultiplyBy3(b);
                case 4: return (a, b) => a & 0x1 | b & 0x2;
                case 5: return (a, b) => (new X()).Y;
                case 6: return (a, b) => tmp.Y;
            }
            throw new NotImplementedException();
        }
    }
}
