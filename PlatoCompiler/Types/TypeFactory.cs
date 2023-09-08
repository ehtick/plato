﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Plato.Compiler.Symbols;

namespace Plato.Compiler.Types
{
    /// <summary>
    /// The type factory creates types from type definition and expression symbols.
    /// It also creates Typed Functions from all function definition symbols.
    /// </summary>
    public class TypeFactory
    {
        public Dictionary<TypeExpressionSymbol, TypeReference> TypeReferences { get; } = new Dictionary<TypeExpressionSymbol, TypeReference>();
        public Dictionary<TypeDefinitionSymbol, TypeDefinition> TypeDefinitions { get; } = new Dictionary<TypeDefinitionSymbol, TypeDefinition>();
        public Dictionary<string, TypeDefinition> TopLevelNamesToTypes { get; } = new Dictionary<string, TypeDefinition>();
        public Dictionary<FunctionDefinition, TypedFunction> TypedFunctions { get; } = new Dictionary<FunctionDefinition, TypedFunction>();
        public TypeReference CurrentSelf { get; set; }

        public TypeFactory(IReadOnlyList<TypeDefinitionSymbol> typeDefinitions)
        {
            // Create type definitions for the built-in primitives 
            foreach (var prim in PrimitiveTypeDefinitions.AllPrimitives)
                CreateAndRegisterDefinition(prim);

            // Create type definitions from all the provided symbols (includes type parameters)
            foreach (var td in typeDefinitions)
                CreateAndRegisterDefinition(td);

            // Resolve all type expression and functions 
            foreach (var t in typeDefinitions)
            {
                // Set the current "self" type to a reference to the current definition
                CurrentSelf = CreateReference(t);

                // Create type references all of the type expressions
                foreach (var symbol in t.GetSymbolTree().OfType<TypeExpressionSymbol>())
                    CreateAndRegisterReference(symbol);

                // Create all of the typed functions
                foreach (var symbol in t.GetSymbolTree().OfType<FunctionDefinition>())
                    CreateAndRegisterTypedFunction(symbol);

                CurrentSelf = null;
            }
        }

        public TypeDefinition CreateAndRegisterDefinition(TypeDefinitionSymbol tds)
        {
            if (TypeDefinitions.ContainsKey(tds)) return TypeDefinitions[tds];
            var tps = tds.TypeParameters.Select(CreateAndRegisterDefinition).ToList();
            var r = new TypeDefinition(tds, tps);
            TypeDefinitions.Add(tds, r);
            if (tds.IsConcreteType() || tds.IsConcept() || tds.IsPrimitive())
                TopLevelNamesToTypes.Add(tds.Name, r);
            return r;
        }

        public IReadOnlyList<Type> CreateTypeArgsAsNecessary(TypeDefinition def)
            => CreateTypeArgsAsNecessary(def, Array.Empty<TypeExpressionSymbol>());
       
        public IReadOnlyList<Type> CreateTypeArgsAsNecessary(TypeDefinition def,
            IReadOnlyList<TypeExpressionSymbol> typeArgs)
        {
            if (typeArgs.Count > def.TypeParameters.Count)
                throw new Exception($"Provided too many type arguments {typeArgs.Count} when {def.TypeParameters.Count} are expected");

            var r = new List<Type>();
            for (var i = 0; i < def.TypeParameters.Count; i++)
            {
                if (i >= typeArgs.Count)
                {
                    // Create extra variables as required. 
                    var arg = new TypeVar(def.TypeParameters[i]);
                    r.Add(arg);
                }
                else
                {
                    // Create the reference to the type arg
                    var arg = CreateAndRegisterReference(typeArgs[i]);
                    r.Add(arg);
                }
            }

            return r;
        }

        public TypeReference CreateAndRegisterReference(TypeExpressionSymbol tes)
        {
            if (TypeReferences.ContainsKey(tes)) 
                return TypeReferences[tes];
            
            if (tes.Name == "Self")
            {
                Debug.Assert(CurrentSelf != null);
                Debug.Assert(tes.TypeArgs.Count == 0);
                TypeReferences.Add(tes, CurrentSelf);
                return CurrentSelf;
            }
            
            var def = GetDefinition(tes.Definition);
            if (def == null)
            {
                throw new Exception($"Unrecognized type definition symbol {tes.Definition} within type expression symbol {tes}");
            }

            var args = CreateTypeArgsAsNecessary(def, tes.TypeArgs);
            var r = new TypeReference(def, args);
            TypeReferences.Add(tes, r);
            return r;
        }

        public TypedFunction GetTypedFunction(FunctionDefinition fd)
            => TypedFunctions[fd];

        public TypeReference GetType(TypeExpressionSymbol typeExpression)
        {
            if (TypeReferences.ContainsKey(typeExpression))
                return TypeReferences[typeExpression];

            if (typeExpression.Name == "Self")
                return CurrentSelf ?? throw new Exception("Self type has not been assigned in current context");

            throw new Exception($"Unrecognized type expression {typeExpression}");
        }

        public Type FindType(string name)
            => TopLevelNamesToTypes[name];

        public TypeVar CreateAny()
            => new TypeVar(null);

        public TypeReference CreateReference(TypeDefinitionSymbol symbol, IReadOnlyList<Type> args)
            => new TypeReference(GetDefinition(symbol), args);

        public TypeReference CreateReference(TypeDefinitionSymbol symbol)
            => CreateReference(symbol, CreateTypeArgsAsNecessary(GetDefinition(symbol)));

        public TypeDefinition GetDefinition(TypeDefinitionSymbol td)
            => TypeDefinitions[td];

        public TypeDefinition GetDefinition(string name)
            => TopLevelNamesToTypes[name];

        public Type CreateTuple(IReadOnlyList<Type> args)
            => CreateReference(PrimitiveTypeDefinitions.Tuples[args.Count], args);
        
        public TypeReference CreateFunctionType(FunctionDefinition fd)
            => CreateFunctionType(fd.Parameters.Select(p => GetType(p.Type)).ToList(),
                GetType(fd.ReturnType));

        private TypeReference CreateFunctionType(IReadOnlyList<Type> paramTypes, Type returnType)
            => CreateReference(PrimitiveTypeDefinitions.Functions[paramTypes.Count], paramTypes.Append(returnType).ToArray());

        private TypedFunction CreateAndRegisterTypedFunction(FunctionDefinition fd)
        {
            var t = CreateFunctionType(fd);
            var tf = new TypedFunction(fd, t);
            TypedFunctions.Add(fd, tf);
            return tf;
        }

        public IEnumerable<TypeDefinition> GetTypesImplementing(TypeDefinition concept)
            => GetConcreteTypes().Where(td => td.Implements(concept));

        public IEnumerable<TypeDefinition> GetConcreteTypes()
            => TypeDefinitions.Values.Where(td => td.IsConcreteType());

        public Type Substitute(Type within, Type original, Type replacement)
        {
            if (within.Equals(original))
                return replacement;
            if (within is TypeReference tr)
                return Substitute(tr, original, replacement);
            if (within is TypeDefinition td)
                return Substitute(td, original, replacement);
            return original;
        }

        public TypeDefinition Substitute(TypeDefinition td, Type original, Type replacement)
            => td.Equals(original) ? (TypeDefinition)replacement : td;

        public TypeReference Substitute(TypeReference tr, Type original, Type replacement)
            => new TypeReference(Substitute(tr.Definition, original, replacement),
                tr.TypeArguments.Select(ta => Substitute(ta, original, replacement)).ToList());

        public IEnumerable<TypedFunctionVariation> CreateVariations(TypedFunction original, TypeFactory factory)
        {
            var typeParams = original.Parameters;
            var r = new HashSet<TypedFunctionVariation>()
            {
                new TypedFunctionVariation(original, original.FunctionType)
            };

            foreach (var p in typeParams)
            {
                if (p.IsConcept())
                {
                    var subs = factory.GetTypesImplementing(p.Definition()).ToList();
                    foreach (var sub in subs)
                    {
                        var newType = factory.Substitute(original.FunctionType, p, sub);
                        var variation = new TypedFunctionVariation(original, newType);
                        r.Add(variation);
                    }
                }
            }

            return r;
        }

        public IEnumerable<TypeDefinition> GetAllImplementedConcepts(TypeDefinition concreteType)
        {
            return concreteType.Symbol.GetAllImplementedConcepts().Select(te => GetType(te).Definition);
        }

        public IEnumerable<TypedFunction> GetAllTypedFunctions(TypeDefinition type)
            => type.Definition().Symbol.Functions.Select(GetTypedFunction);

        public TypedFunctionVariation CreateVariation(TypedFunction function, Type newFuncType)
        {
            return new TypedFunctionVariation(function, newFuncType);
        }

        public IEnumerable<TypedFunctionVariation> GetAllConceptFunctionVariations(TypeDefinition concreteType, TypeDefinition concept)
        {
            foreach (var tf in GetAllTypedFunctions(concept))
            {
                yield return CreateVariation(tf, Substitute(tf.FunctionType, concept, concreteType));
            }
        }
    }
}