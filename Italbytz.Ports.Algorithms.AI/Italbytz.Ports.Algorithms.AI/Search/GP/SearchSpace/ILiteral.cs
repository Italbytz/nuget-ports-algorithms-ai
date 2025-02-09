using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Algorithms.AI.Search.GP.SearchSpace;

public interface ILiteral<TCategory> : IComparable<ILiteral<TCategory>>
{
    public bool[] Predictions { get; set; }
    public string Label { get; set; }
    public void GeneratePredictions(List<TCategory> data);
}