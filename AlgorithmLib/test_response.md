# CSE 381 - Final Exam

(c) BYU-Idaho - It is an honor code violation ot post this file completed or uncompleted in a public sharing site.

Instructions: Record your answers to the final exam below. Remember to put your name and date below.

Name: Alexander Perazzo

Date: 12/23

## Part 1

1. An algorithm is a discrete set of steps that acheives a specific result. An algorithm is commonly repeatable and consistent; every time you repeat an algorithm you should get the same results.

   Because many programming languages share a similar set of tools (or at the very least, are capable of using their tools in a way to copy the tools of other languages) algorithms are repeatable across programming lanaguages. And, frequently, different programming languages want to do the same exact thing -- hence using the same exact algorithm.

   I think this shows how useful the idea of an algorithm is. It's a repeatable discrete set of steps to accomplish a task. Practically every programming language that I can think of at some point or another wants to sort items in one way or another. An algorithm makes this easy to accomplish across all programming languages. It allows programmers to not reinvent the wheel. This means programmers can build off what previous programmers have done. We can learn from each other and from past programmers to become the best we can become.

2. The running time performance of an algorithm is commonly measured in Big O notation. Big O notation takes an input 'n'. The base idea is asking the question, "How much slower does my algorithm get the more the input increases?"

   The best way of discerning this is figuring out how much or how frequently the input is used in the algorithm. You ask the quesiton, "For every item I input, does it increase the time performance of my alogrithm linearly, logrithmically, or exponentially?"

   This is most easily discovered by looking for two key attributes: 1. Loops 2. Cutting out part of the input.

   If the algorithm simply uses each input once (a simple loop), it is O(n). If there is a loop in a loop, it is O(n^2). If there's a loop in a loop in a loop, it is O(n^3), and so on.

   If, on the other hand, you notice the algorithm not using your entire input, there's a chance is is logrithmic in some form. If on every cycle you're cutting out half of your input, it is O(log(n)).

   Big O notation is meant to describe the worse-case scenarios. As n approaches infinity, any constant out in front matters less and less. So when we're describing Big(O), we don't write any constants out front. This is not to say the constants are entirely unimportant for when writing code, your input will not be infinite. Best-case and average-case notations exist as well, but Big O notation is the most common notation.

3.
DAG Shortest Path:
A Directed Acyclic Graph is a graph that has no cycles, and this algorithm takes advantage of that. Effectively, it searches every possible route and updates the shortest paths as it goes along.

Dijkstra's Shortest Path:
This works on graphs that have cycles but no negatively weighted edges.
This will check every possible edge we could go through. It finds the smallest weight and goes to that point. It proceeds to relax all the all of its neighbors. We continue this process of checking the shortest edges until we have no more edges to check.

Bellman-Ford Shortest Path:
This works on graphs that have cycles and have negatively weighted edges. The Bellman-Ford shortest path functions very similarly to the Dijkstra's Shortest Path in terms of looking at the next edge and relaxing its neighbors. However, it repeats this process several times to check for negative cycles.

Efficiency:
Regardless of how dense or sparse the graph is, DAG Shortest Path needs to check every edge and go to every vertex exactly once. This makes the best and worst case always V+E (where V = number of vertexes and E = number of edges).

This contrasts greatly with Dijkstra and BellmanFord because DAG Shortest Path is implemented on DAG's -- there are no cycles.

Dijkstra's worst case is O(V^2) and best case is Omega(E+VlogV).
BellmanFord's Worst Case is O(VE) and best case is Omega(V+E).

As the graph becomes more and more dense, the E slowly becomes equal to V. BellmanFord does not handle this well as it's O(VE) now becomes non-linear with O(V^2). On the other hand, Dijkstra's worst case doesn't depend on E, thus it handles dense graphs pretty well. It's worst case scenario is the same for sparse and dense graphs, it's still O(V^2).

An additional semi-obvious note about their efficiency: They work most effectively on specific types of graphs. And sometimes they don't even work on other types of graphs. If you want the best performance, you use DAG Shortest Path on DAG's, Dijkstra's Shortest Path on graphs with no negatively weighted sides, and BellmanFord's Shortest Path on graphs with negatively weighted sides.

## Part 2

Algorithm Selected: HuffmanTreeCompression

Public or Unlisted (not private) YouTube URL for your video:
https://youtu.be/4yu__F7VuQA
