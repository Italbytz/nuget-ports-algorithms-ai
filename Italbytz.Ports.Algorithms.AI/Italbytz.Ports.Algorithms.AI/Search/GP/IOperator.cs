using Italbytz.Ports.Algorithms.AI.Search.GP.Individuals;

namespace Italbytz.Ports.Algorithms.AI.Search.GP;

public interface IOperator
{
    public IIndividualList Process(IIndividualList individuals);
}