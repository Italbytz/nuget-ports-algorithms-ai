using System;

namespace Italbytz.Ports.Algorithms.AI.Logic.Fol.Parsing.Ast;

public interface IConstant : ITerm, IEquatable<IConstant>
{
    public string Value { get; }
}