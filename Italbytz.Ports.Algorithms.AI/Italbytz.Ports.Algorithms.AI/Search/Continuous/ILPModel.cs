using System.Collections.Generic;

namespace Italbytz.Ports.Algorithms.AI.Search.Continuous
{
    public interface ILPModel
    {
        public bool Maximization { get; set; }
        public double[] ObjectiveFunction { get; set; }
        public (double, double)[] Bounds { get; set; }
        public List<ILPConstraint> Constraints { get; set; }
        public bool[] IntegerVariables { get; set; }
    }
}