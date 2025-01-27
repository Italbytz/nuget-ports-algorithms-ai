using System.Collections.Generic;
using Italbytz.Ports.Algorithms.AI.Search.GP.Crossover;
using Italbytz.Ports.Algorithms.AI.Search.GP.Fitness;
using Italbytz.Ports.Algorithms.AI.Search.GP.Individuals;
using Italbytz.Ports.Algorithms.AI.Search.GP.Initialization;
using Italbytz.Ports.Algorithms.AI.Search.GP.Mutation;
using Italbytz.Ports.Algorithms.AI.Search.GP.PopulationManager;
using Italbytz.Ports.Algorithms.AI.Search.GP.SearchSpace;
using Italbytz.Ports.Algorithms.AI.Search.GP.Selection;
using Italbytz.Ports.Algorithms.AI.Search.GP.StoppingCriterion;
using Microsoft.ML;

namespace Italbytz.Ports.Algorithms.AI.Search.GP;

public interface IGeneticProgram
{
    public List<IMutation> Mutations { get; set; }
    public List<ICrossover> Crossovers { get; set; }
    public IDataView TrainingData { get; set; }
    public IIndividualList Population { get; }

    public IInitialization Initialization { get; set; }


    public IPopulationManager PopulationManager { get; set; }
    public ISearchSpace SearchSpace { get; set; }
    public ISelection SelectionForOperator { get; set; }

    public ISelection SelectionForSurvival { get; set; }

    public IStoppingCriterion[] StoppingCriteria { get; set; }
    int Generation { get; set; }
    IFitnessFunction FitnessFunction { get; set; }

    public void InitPopulation();
    public IIndividualList Run();
}