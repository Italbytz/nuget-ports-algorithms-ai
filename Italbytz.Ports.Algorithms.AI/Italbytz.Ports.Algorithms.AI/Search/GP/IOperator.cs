// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

using Italbytz.Ports.Algorithms.AI.Search.GP.Individuals;

namespace Italbytz.Ports.Algorithms.AI.Search.GP;

/// <summary>
/// An operator that processes indiviuals. 
/// </summary>
public interface IOperator
{
    /// <summary>
    /// Computes the output of the operator from the input.
    /// Must return an array of IndividualList.
    /// </summary>
    /// <param name="individuals">Input individuals</param>
    /// <returns>Output individuals</returns>
    public IIndividualList Process(IIndividualList individuals);
}

