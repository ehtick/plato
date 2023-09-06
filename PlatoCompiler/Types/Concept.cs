﻿using System;
using System.Collections.Generic;
using System.Linq;
using Plato.Compiler.Symbols;

namespace Plato.Compiler.Types
{
    public class Concept
    {
        public IReadOnlyList<Type> InheritedTypes { get; }
        public List<TypedFunction> Functions { get; } = new List<TypedFunction>();
        public TypeDefinitionSymbol Definition { get; }
        public string Name => Definition.Name;

        public Concept(TypeDefinitionSymbol definition, IReadOnlyList<Type> inheritedTypes, TypeFactory factory)
        {
            if (!definition.IsConcept())
                throw new Exception("Expected a concept");
            Definition = definition;
            InheritedTypes = inheritedTypes;
        }
    }
}