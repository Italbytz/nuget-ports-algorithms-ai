using System;

namespace Italbytz.Ports.Algorithms.AI.Search.GP.Individuals;

public interface IIndividual : ICloneable
{
    public IGenotype Genotype { get; }
    public double[]? LatestKnownFitness { get; set; }
    int Size { get; }
    int Generation { get; set; }
    bool IsDominating(IIndividual otherIndividual);
}