using System.Collections.Generic;
using Italbytz.Ports.Algorithms.AI.Logic.Fol.Kb.Data;

namespace Italbytz.Ports.Algorithms.AI.Logic.Planning;

public interface IPlanningProblem
{
    public IList<ILiteral> Goal { get; }
    public IState InitialState { get; }
    IEnumerable<IActionSchema> GetPropositionalisedActions();
}