using Italbytz.Ports.Algorithms.AI.Search.GP.Individuals;

namespace Italbytz.Ports.Algorithms.AI.Search.GP.SearchSpace;

public interface ISearchSpace
{
    IGenotype GetRandomGenotype();
    IIndividualList GetAStartingPopulation();
}