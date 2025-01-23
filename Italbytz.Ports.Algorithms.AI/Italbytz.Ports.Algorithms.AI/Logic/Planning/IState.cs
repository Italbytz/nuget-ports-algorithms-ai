using System.Collections.Generic;
using Italbytz.Ports.Algorithms.AI.Logic.Fol.Kb.Data;

namespace Italbytz.Ports.Algorithms.AI.Logic.Planning;

public interface IState
{
    public IList<ILiteral> Fluents { get; }
    IState Result(List<IActionSchema> actions);
    public bool IsApplicable(IActionSchema action);
}