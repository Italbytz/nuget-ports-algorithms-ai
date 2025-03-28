# Introduction

The [Hexagonal Architecture](https://web.archive.org/web/20180822100852/http://alistair.cockburn.us/Hexagonal+architecture), also known as the Ports and Adapters pattern, is a design approach that emphasizes separation of concerns by isolating the core application logic from external systems like databases, user interfaces, or APIs. This is achieved through the use of "ports" (interfaces) and "adapters" (implementations), enabling easier testing, maintainability, and flexibility in swapping external dependencies without affecting the core logic.

This repository provides C# ports for Artificial Intelligence projects. The NuGet package is called [Italbytz.Ports.Algorithms](https://www.nuget.org/packages/Italbytz.Ports.Algorithms) and offers a [docfx](https://italbytz.github.io/nuget-ports-algorithms/) page.

The main external sources of inspiration are

- [Russell](http://www.cs.berkeley.edu/~russell/) And [Norvig's](http://www.norvig.com/) [Artificial Intelligence - A Modern Approach 3rd Edition](http://aima.cs.berkeley.edu/)(AIMA)
- [FrEAK](https://sourceforge.net/projects/freak427/)

## Index of ports for AIMA algorithms

Note, that there is an official repository for C# implementations called [aima-csharp](https://github.com/aimacode/aima-csharp) which does not use ports and adapters but may provide algorithms not yet provided here. Also note, that the official Python and Java repositories [aima-python](https://github.com/aimacode/aima-python) and [aima-java](https://github.com/aimacode/aima-java) are far more complete. A lot of the code provided here is based on the official Java code.

Here is a table of algorithms, the figure, name of the code in the book, and the file where they are provided in the code. This chart was made for the third edition of the book. The [aima-pseudocode](https://github.com/aimacode/aima-pseudocode) project describes all the algorithms from the book.

|Fig|Page|Name (in book)|Code|
| -------- |:--------:| :-----| :----- |
|2|34|Environment|[IEnvironment](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Agent/IEnvironment.cs)|
|2.1|35|Agent|[IAgent](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Agent/IAgent.cs)|
|3|66|Problem|[IProblem](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Problem/IProblem.cs)|
|3.10|79|Node|[INode](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Search/INode.cs)|
|4|147|Online search problem|[IOnlineSearchProblem](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Problem/IOnlineSearchProblem.cs)|
|5.3|166|Adversarial Search|[IAdversarialSearch](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Search/Adversarial/IAdversarialSearch.cs)|
|6|202|CSP|[ICSP](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Search/CSP/ICSP.cs)|
|10.9|383|Planning|[IPlanningProblem](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Logic/Planning/IPlanningProblem.cs)|
|18.5|702|Learner|[ILearner](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/Learning/ILearner.cs)|

## Additional ports for Evolutionary Algorithms and Genetic Programming

The additional ports for Evolutionary Algorithms and Genetic Programming are currently mainly used for [logicGP](https://github.com/RobinNunkesser/csharp-console-logicgp) and provided in [Genetic Programming](https://github.com/Italbytz/nuget-ports-algorithms-ai/blob/main/Italbytz.Ports.Algorithms.AI/Italbytz.Ports.Algorithms.AI/GP).

# Getting Started

[csharp-mstest-ai](https://github.com/RobinNunkesser/csharp-mstest-ai) contains a set of unit tests demonstrating the use of the provided ports and adapters.