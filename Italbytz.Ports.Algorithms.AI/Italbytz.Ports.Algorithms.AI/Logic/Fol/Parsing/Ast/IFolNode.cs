using Italbytz.Ports.Algorithms.AI.Logic.Common;

namespace Italbytz.Ports.Algorithms.AI.Logic.Fol.Parsing.Ast;

public interface IFolNode : IParseTreeNode
{
    public string SymbolicName { get; }
}