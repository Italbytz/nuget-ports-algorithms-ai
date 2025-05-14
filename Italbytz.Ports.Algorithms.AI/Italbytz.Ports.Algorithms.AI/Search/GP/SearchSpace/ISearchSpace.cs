// The original version of this file is part of 
// <see href="https://sourceforge.net/projects/freak427/"/> which is released 
// under GPLv2
// Copyright (c) 2003 Patrick Briest, Dimo Brockhoff, Sebastian Degener, 
// Matthias Englert, Christian Gunia, Oliver Heering, Thomas Jansen, 
// Michael Leifhelm, Kai Plociennik, Heiko Roeglin, Andrea Schweer, 
// Dirk Sudholt, Stefan Tannenbaum, Ingo Wegener

using Italbytz.AI.Search.GP.Individuals;

namespace Italbytz.AI.Search.GP.SearchSpace;

/// <summary>
/// Defines a search space for genetic programming algorithms.
/// </summary>
/// <remarks>
/// A search space provides methods to generate random genotypes and initial populations
/// for genetic programming algorithms.
/// </remarks>
public interface ISearchSpace
{
    IGenotype GetRandomGenotype();
    IIndividualList GetAStartingPopulation();
}