using System.Collections.Generic;

namespace Italbytz.Ports.Algorithms.AI.Search.GP.Individuals;

public interface IIndividualList : IEnumerable<IIndividual>
{
    IIndividual this[int index] { get; }
    void Add(IIndividual individual);
    IIndividual GetRandomIndividual();

    List<IIndividual> ToList();
}