using Italbytz.Ports.Algorithms.AI.Search.GP.Individuals;
using Italbytz.Ports.Algorithms.AI.Search.GP.Initialization;

namespace Italbytz.Ports.Algorithms.AI.Search.GP.PopulationManager;

public interface IPopulationManager
{
    public IIndividualList Population { get; set; }
    public void InitPopulation(IInitialization initialization);

    
}