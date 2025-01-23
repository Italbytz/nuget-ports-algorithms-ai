using System;
using System.Collections.Generic;
using Italbytz.Ports.Algorithms.AI.Logic.Fol.Kb.Data;
using Italbytz.Ports.Algorithms.AI.Logic.Fol.Parsing.Ast;

namespace Italbytz.Ports.Algorithms.AI.Logic.Planning;

public interface IActionSchema : IEquatable<IActionSchema>
{
    public List<ITerm> Variables { get; }
    public IList<ILiteral> Precondition { get; }

    public IList<ILiteral> Effect { get; }

    public string Name { get; }
}