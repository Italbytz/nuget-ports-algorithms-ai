using System;

namespace Italbytz.Ports.Algorithms.AI.Search.CSP;

public interface IVariable : IEquatable<IVariable>
{
    public string Name { get;  }
}