# Algorithm Description Document

Author: Alexander Perazzo

Date: 10/14/23

## 1. Name
Directed Acyclic Graph (DAG) Shortest Path

## 2. Abstract
This algorithm, as its name suggests, finds the shortest path in a DAG. It starts by seeing the distance from the start point to anything it's connected to. Then, it continues along those paths (but no others to save on time), each time it keeps track of its distance from the start. It does this until it gets to the end -- the shortest distance is saved.

## 3. Methodology
This algorithm takes a topolocially-sorted graph with a desired start point. Generally when used, people have an end point in mind as well, but this is not needed as the end result will be the same with or without an end point specified. The end result is a list of distances from the start point to every other point. If it is impossible to reach a certain other vertex, it will display a null value or something similar (in our case "INF").

The algorithm itself is actually quite simple. It has a list for distances from the start point and a list for the predecessor. The algorithm cycles through the edges of the start vertex. For each edge, it updates the distance list. Because these edges are the only possible way to be connected to the start vertex, we will then look at these edges' edges.

Each time, it will update the distance list -- but not with just the distance between the vertex we're at to the vertex we're going to, but rather the entire distance from the start vertex to this current vertex.

The algorithm will loop through updating the distance list. The predecessor list is also updated. Whatever vertex led to the current vertex is put there. This allows us, at the end, to know which path we took to get to the end point.

The end point is not specified because every path must be travelled to ensure we have the shortest path. This means our output list actually has a list of all the distances from our start vertex.

## 4. Pseudocode

```
SHORTEST-PATH(graph, start_vertex)

```

## 5. Inputs & Outputs

Inputs: Graph (a list of vertexes (vertexes in our case are just ints) that are sorted topologically)
StartVertex (an int of the vertex you want to start at)

Outputs: Two lists. 1. Distance list -- it is a list of the distance from the starting vertex to every other vertex in the graph (int). 2. A predecessor list -- it is a list of every vertex's parent. Or, in other words, where every vertex came from (int).

## 6. Analysis Results

* Worst Case: $O(V+E)$
* (V meaning number of vertexes and E being number of Edges)

* Best Case: $\Omega(V+E)$
* (V meaning number of vertexes and E being number of Edges)

