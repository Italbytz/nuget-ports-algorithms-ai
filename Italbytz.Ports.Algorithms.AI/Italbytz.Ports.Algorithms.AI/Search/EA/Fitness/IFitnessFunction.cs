using Italbytz.AI.Search.EA.Individuals;
using Microsoft.ML;

namespace Italbytz.AI.Search.EA.Fitness;

/// <summary>
///     Defines a fitness function for genetic programming algorithms.
/// </summary>
/// <remarks>
///     Fitness functions evaluate individuals in a population against a dataset to
///     determine
///     how well they perform on a specific problem or set of objectives.
/// </remarks>
public interface IFitnessFunction
{
    /// <summary>
    ///     Gets the number of objectives this fitness function evaluates.
    /// </summary>
    /// <remarks>
    ///     For single-objective optimization, this will be 1. For multi-objective
    ///     optimization, this will be greater than 1.
    /// </remarks>
    public int NumberOfObjectives { get; }

    /// <summary>
    ///     Gets or sets the name of the column in the data containing the target
    ///     values (labels).
    /// </summary>
    public string LabelColumnName { get; set; }

    /// <summary>
    ///     Evaluates the fitness of an individual against the provided data.
    /// </summary>
    /// <param name="individual">The individual to evaluate.</param>
    /// <param name="data">The data to evaluate the individual against.</param>
    /// <returns>
    ///     An array of fitness values, with one value per objective.
    ///     Higher values typically indicate better performance.
    /// </returns>
    public double[] Evaluate(IIndividual individual, IDataView data);
}