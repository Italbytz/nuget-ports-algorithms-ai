using System;
using Italbytz.Ports.Algorithms.AI.Logic.Fol.Parsing.Ast;

namespace Italbytz.Ports.Algorithms.AI.Logic.Fol.Kb.Data;

public interface ILiteral : IEquatable<ILiteral>
{
    public bool NegativeLiteral { get; }

    public bool PositiveLiteral { get; }
    public IAtomicSentence Atom { get; }
    ILiteral GetComplementaryLiteral();
}