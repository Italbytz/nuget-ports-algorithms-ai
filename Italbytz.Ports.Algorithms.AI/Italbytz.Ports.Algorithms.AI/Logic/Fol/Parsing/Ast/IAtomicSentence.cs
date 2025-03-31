// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System.Collections.Generic;

namespace Italbytz.Ports.Algorithms.AI.Logic.Fol.Parsing.Ast;

public interface IAtomicSentence : ISentence
{
    public IList<ITerm> Args { get; }
}