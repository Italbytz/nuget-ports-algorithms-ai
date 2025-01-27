using Italbytz.Ports.Algorithms.AI.Search.GP.Individuals;
using Microsoft.ML;

namespace Italbytz.Ports.Algorithms.AI.Search.GP.Fitness;

public interface IFitnessFunction
{
    public int NumberOfObjectives { get; }

    public string LabelColumnName { get; set; }

    public double[] Evaluate(IIndividual individual, IDataView data);
}