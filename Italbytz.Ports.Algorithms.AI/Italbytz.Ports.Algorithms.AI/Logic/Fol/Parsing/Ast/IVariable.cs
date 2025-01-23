using System;

namespace Italbytz.Ports.Algorithms.AI.Logic.Fol.Parsing.Ast;

public interface IVariable : ITerm, IEquatable<IVariable>
{
    int Indexical { get; }
}