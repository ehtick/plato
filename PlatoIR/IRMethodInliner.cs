﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PlatoIR
{

    public class IRMethodInliner
    {
        public Dictionary<MethodDeclarationIR, MethodDeclarationIR> Inlined =
            new Dictionary<MethodDeclarationIR, MethodDeclarationIR>();

        public static int VarId = 0;

        public IR Inline(IR ir)
        {
            if (ir is MethodReferenceIR methodRef)
            {
                var decl = GetOrComputeInlined(methodRef.MethodDeclaration);
                if (decl == null) return ir;
                return new MethodReferenceIR(decl.Name, methodRef.Receiver.Rewrite(Inline), decl,
                    methodRef.TypeArguments);
            }

            if (ir is MethodDeclarationIR methodDeclaration)
            {
                return GetOrComputeInlined(methodDeclaration);
            }

            return ir;
        }

        public static IR ReplaceParameters(IR ir, Dictionary<ParameterDeclarationIR, ExpressionIR> replacements,
            Dictionary<TypeParameterDeclarationIR, TypeReferenceIR> typeReplacements)
        {
            if (ir is ParameterReferenceIR pir)
            {
                var pDecl = pir.ParameterDeclaration;
                if (pDecl != null && replacements.ContainsKey(pDecl))
                {
                    return replacements[pDecl];
                }
            }

            if (ir is TypeReferenceIR tir)
            {
                if (tir.TypeParameterDeclaration != null && typeReplacements.ContainsKey(tir.TypeParameterDeclaration))
                {
                    return typeReplacements[tir.TypeParameterDeclaration];
                }
            }

            return ir;
        }

        public static IR ReplaceReturnStatements(IR ir, VariableDeclarationIR resultVar)
        {
            if (ir is ReturnStatementIR rst)
            {
                return new ExpressionStatementIR(
                    new AssignmentIR(new VariableReferenceIR(resultVar.Name, resultVar), rst.Expression));
            }

            if (ir is LambdaIR lambda)
            {
                // Prevents recursing into lambdas (they have return statements too, but they must stay as is).
                return lambda.Clone();
            }

            return ir;
        }

        public static (MultiStatementIR, VariableDeclarationIR) InvocationToStatement(InvocationIR invocation)
        {
            var methodRef = invocation.Function as MethodReferenceIR;
            var lambda = invocation.Function as LambdaIR;
            var method = methodRef?.MethodDeclaration;
            var parameters = method?.Parameters ?? lambda?.Parameters ?? new List<ParameterDeclarationIR>();
            var typeArgs = methodRef?.TypeArguments ?? new List<TypeReferenceIR>();
            var typeParameters = method?.TypeParameters ?? new List<TypeParameterDeclarationIR>();
            var body = method?.Body ?? lambda?.Body;

            if (body == null)
                return (null, null);

            var resultVar = new VariableDeclarationIR()
            {
                InitialValue = new DefaultIR(invocation.ExpressionType),
                IsStatic = false,
                Name = $"result_{VarId}",
                Parent = null,
                ParentType = null,
                Type = invocation.ExpressionType,
            };
            VarId++;
            var r = new MultiStatementIR();

            r.Statements.Add(new DeclarationStatementIR(resultVar));

            var block = new BlockStatementIR();
            var parameterReplacements = new Dictionary<ParameterDeclarationIR, ExpressionIR>();
            var typeReplacements = new Dictionary<TypeParameterDeclarationIR, TypeReferenceIR>();

            var args = invocation.Args.ToList();
            if (parameters.Count > 0)
            {
                if (parameters[0].IsThisParameter && methodRef?.Receiver != null)
                {
                    args.Insert(0, methodRef.Receiver);
                }
            }

            for (var i = 0; i < typeArgs.Count; ++i)
            {
                var typeRef = typeArgs[i];
                var typeParam = typeParameters[i];
                typeReplacements.Add(typeParam, typeRef);
            }

            for (var i = 0; i < parameters.Count; i++)
            {
                var p = parameters[i];

                var arg = i < args.Count ? args[i] : p.DefaultValue;
                if (arg == null)
                {
                    throw new Exception(
                        $"Could not find the correct argument for parameter {p} as position {i} of method {method}");
                }

                if (arg is InvocationIR)
                {
                    var decl = new VariableDeclarationIR()
                    {
                        Type = p.Type,
                        Name = $"{p.Name}_{VarId}",
                        InitialValue = arg,
                    };
                    VarId++;
                    parameterReplacements.Add(p, decl.ToReference());
                    block.Statements.Add(new DeclarationStatementIR(decl));
                }
                else
                {
                    parameterReplacements.Add(p, arg);
                }
            }

            block.Statements.Add(body);
            r.Statements.Add(block);
            r.Statements = r.Statements
                .Rewrite(ir => ReplaceParameters(ir, parameterReplacements, typeReplacements))
                .Rewrite(ir => ReplaceReturnStatements(ir, resultVar)).ToList();

            var replaceString1 = string.Join("\n", parameterReplacements.Select(kv => $"{kv.Key} <-- {kv.Value}"));
            var replaceString2 = string.Join("\n", typeReplacements.Select(kv => $"{kv.Key} <-- {kv.Value}"));

            resultVar.Source = $"Inlining {invocation}\nparameters:\n{replaceString1}\ntypes:\n{replaceString2}";

            return (r, resultVar);
        }

        public static IR InlineInvocations(IR ir)
        {
            if (ir is StatementIR st)
            {
                var newStatements = new List<StatementIR>();
                var lookup = new Dictionary<InvocationIR, VariableReferenceIR>();
                foreach (var invocation in st.GetExpressions().OfType<InvocationIR>())
                {
                    var (newStatement, resultVar) = InvocationToStatement(invocation);
                    if (newStatement == null || resultVar == null) continue;
                    lookup.Add(invocation, resultVar.ToReference());
                    newStatements.Add(newStatement);
                }

                if (lookup.Count == 0)
                    return ir;

                newStatements.Add(st.Replace(lookup) as StatementIR);
                return new MultiStatementIR(newStatements);
            }

            return ir;
        }

        public MethodDeclarationIR GetOrComputeInlined(MethodDeclarationIR original)
        {
            if (original == null) return null;
            if (Inlined.ContainsKey(original)) return Inlined[original];
            if (original is OperationDeclarationIR) return original;

            var result = (MethodDeclarationIR)original.Clone();
            result.Name = $"_inlined_{original.Name}";
            result = result.Rewrite(Inline).Rewrite(InlineInvocations) as MethodDeclarationIR;
            Inlined.Add(original, result);
            return result;
        }
    }
}