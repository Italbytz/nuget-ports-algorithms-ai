namespace Italbytz.Ports.Algorithms.AI.Search.GP.Selection;

public interface ISelection : IOperator
{
    public int Size { get; set; }
}