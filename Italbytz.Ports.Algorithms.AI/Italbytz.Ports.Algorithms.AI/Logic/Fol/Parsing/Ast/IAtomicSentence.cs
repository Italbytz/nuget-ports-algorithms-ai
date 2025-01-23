using System.Collections.Generic;

namespace Italbytz.Ports.Algorithms.AI.Logic.Fol.Parsing.Ast;

public interface IAtomicSentence : ISentence
{
    public IList<ITerm> Args { get; }
}