﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace PlatoAst
{
    public class Constraint  
    { }

    public class MemberAccessConstraint : Constraint
    {
        public MemberAccessSymbol MemberAccess { get; }
        public MemberAccessConstraint(MemberAccessSymbol symbol)
            => MemberAccess = symbol;

        public override string ToString()
            => $"Accessed:.{MemberAccess.Name}";
    }

    public class FunctionArgConstraint : Constraint
    {
        public Symbol Function { get; }
        public int Position { get; }

        public FunctionArgConstraint(Symbol fs, int position)
            => (Function, Position) = (fs, position);

        public override string ToString()
            => $"Passed:{Function}(arg[{Position})";
    }

    public class FunctionCallConstraint : Constraint
    {
        public IReadOnlyList<Symbol> Args { get; }

        public FunctionCallConstraint(IEnumerable<Symbol> args)
            => Args = args.ToList();

        public override string ToString()
            => $"Invoked:({string.Join(",", Args)})";
    }

    public static class Constraints
    {
        public static Dictionary<ParameterSymbol, List<Constraint>> GetParameterConstraints(FunctionSymbol f)
        {
            var r = new Dictionary<ParameterSymbol, List<Constraint>>();

            if (f != null)
            {
                foreach (var ps in f.Parameters)
                {
                    if (!r.ContainsKey(ps))
                        r.Add(ps, new List<Constraint>());
                }

                foreach (var sym in f.Body.AllDescendantSymbols())
                {
                    if (sym is MemberAccessSymbol mas)
                    {
                        if (mas.Receiver is RefSymbol rs && rs.Def is ParameterSymbol ps)
                        {
                            if (r.ContainsKey(ps))
                            {
                                r[ps].Add(new MemberAccessConstraint(mas));
                            }
                        }
                    }
                    else if (sym is FunctionResultSymbol fs)
                    {
                        {
                            if (fs.Function is RefSymbol rs && rs.Def is ParameterSymbol ps)
                            {
                                if (r.ContainsKey(ps))
                                {
                                    r[ps].Add(new FunctionCallConstraint(fs.Args));
                                }
                            }
                        }

                        foreach (var arg in fs.Args)
                        {
                            if (arg.Original is RefSymbol rs && rs.Def is ParameterSymbol ps)
                            {
                                if (r.ContainsKey(ps))
                                {
                                    r[ps].Add(new FunctionArgConstraint(fs.Function, arg.Position));
                                }
                            }
                        }
                    }
                }
            } 
            return r;
        }
    }
}
