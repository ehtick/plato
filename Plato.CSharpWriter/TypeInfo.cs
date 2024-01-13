﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Ara3D.Utils;
using Plato.Compiler.Symbols;
using Plato.Compiler.Types;

namespace Plato.CSharpWriter
{
    /// <summary>
    /// Contains extra information about a type used in the analyses. 
    /// </summary>
    public class TypeInfo
    {
        public TypeExpression ActualType { get; }
        public TypeExpression OriginalType { get; }
        public string OriginalName => OriginalType.Name;
        public bool IsSelfConstrained => OriginalDefinition.IsSelfConstrained();
        public TypeDefinition OriginalDefinition => OriginalType.Definition;
        public bool IsGeneric => TypeParameters.Count > 0;
        public bool IsConcept => OriginalDefinition.IsConcept();
        public bool IsConcrete => OriginalDefinition.IsConcrete();

        public TypeInfo(TypeExpression original, TypeExpression actual)
        {
            Debug.Assert(OriginalType != null);
            Debug.Assert(OriginalDefinition != null);
            Debug.Assert(OriginalType.TypeArgs.Count == 0);
            // Either IsConcept, or IsConcrete, but never both or neither. 
            Debug.Assert(IsConcept ^ IsConcrete);
        }

        public IReadOnlyList<TypeParameterDefinition> TypeParameters
            => OriginalDefinition.TypeParameters;

        public IEnumerable<string> TypeParameterNames
            => TypeParameters.Select(tp => tp.Name);

        public string TypeParameterStr
            => TypeParameters.Count > 0 ? "" : "<" + TypeParameterNames.JoinStringsWithComma() + ">";

        public override string ToString()
            => $"{Name}{TypeParameterStr}";

        public override int GetHashCode()
            => ToString().GetHashCode();

        public override bool Equals(object obj)
            => obj is TypeInfo ti && ToString() == ti.ToString();
    }
}