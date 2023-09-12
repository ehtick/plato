﻿using System.Collections.Generic;
using System.Linq;

namespace Plato.Compiler.Symbols
{
    public interface IFunction
    {
        string Name { get; }
        int NumParameters { get; }
        ExpressionSymbol Body { get; }
        string GetParameterName(int n);
        TypeExpressionSymbol GetParameterType(int n);
        TypeExpressionSymbol ReturnType { get; }
        TypeDefinitionSymbol OwnerType { get; }
    }

    public static class FunctionExtensions
    {
        public static IReadOnlyList<(string, TypeExpressionSymbol)> GetParameters(this IFunction self) 
            => Enumerable
                .Range(0, self.NumParameters)
                .Select(i => (self.GetParameterName(i), self.GetParameterType(i)))
                .ToList();

        public static string GetSignature(this IFunction self) =>
            $"{self.OwnerType}::{self.Name}("
            + string.Join(",", self.GetParameters().Select(p => $"{p.Item1}:{p.Item2}"))
            + $"):{self.ReturnType};";
    }
}