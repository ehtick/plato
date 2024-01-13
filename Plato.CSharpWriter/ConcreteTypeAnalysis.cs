﻿using System.Collections.Generic;
using System.Linq;
using Ara3D.Utils;
using Plato.Compiler.Symbols;
using Plato.Compiler.Types;

namespace Plato.CSharpWriter
{
    /// <summary>
    /// Holds a list of all the functions associated with the type,
    /// and the implemented concepts.
    /// </summary>
    public class ConcreteTypeAnalysis
    {
        public TypeDefinition ConcreteType { get; }
        public LibraryAnalysis Libraries { get; }
        public IReadOnlyList<ConceptImplementation> Concepts { get; }
        public IReadOnlyList<FunctionAnalysis> ConcreteFunctions { get; }

        public ConcreteTypeAnalysis(TypeDefinition concreteType, LibraryAnalysis libraries)
        {
            Verifier.AssertNotNull(concreteType, nameof(concreteType));
            Verifier.AssertNotNull(libraries, nameof(libraries));
            Verifier.Assert(concreteType.IsConcrete());
            ConcreteType = concreteType;
            Libraries = libraries;
            Concepts = concreteType.Implements.Select(CreateConceptImplementation).ToList();
            ConcreteFunctions = libraries.GetFunctionsForType(ConcreteType.Name).Select(AnalyzeConcreteFunction).ToList();
        }

        public ConceptImplementation CreateConceptImplementation(TypeExpression type)
            => new ConceptImplementation(Libraries, ConcreteType, TypeSubstitutions.Create(type), type);

        public FunctionAnalysis AnalyzeConcreteFunction(FunctionDefinition function)
            => new FunctionAnalysis(ConcreteType, function, new TypeSubstitutions());
    }
}