# Algorithm Description Document

Author: Alexander Perazzo

Date: 10/18/23 

## 1. Name
Dijkstra Shortest Path

## 2. Abstract
The Dijkstra Shortest Path algorithm takes a list of nodes with various weights between them and a starting node. It will return the distance (the total weight) it takes to get from the starting node to every other node. It does this by looping through all the nodes and their edges, always taking the closest unvisited node next. This guarantees the shortest distance from the starting node to every other node will be found.

## 3. Methodology
There is a list of the distance, list of predecessors (only necessary if you want the way to get to the place on top of how far away the place is), a list of nodes (with their edges (aka a graph)) and whether those nodes have been visited or not.

You choose a starting node. You set its distance to 0 and all other distances to infinity. The node is popped off. Whenever this takes place, all edges to that node are viewed. The total distance from the start (currently 0, of course) plus the weight of that edge are inputted into the distance list ONLY if that distance is smaller than the currently inputted one. Then update the predecessor list with the node we just visited. You can mark this node off as visited. 

You then do this same process with the closest non-visited node. You check its edges, if the distance to that node + the weight of that edge is smaller than the distance currently recorded, you replace it updating the various lists as explained. You do this until all nodes have been visited.

This process guarantees the shortest distance will be found to each node from the starting node because the next closest node is the one being viewed over. The fact that it is the next closest means there is no other faster way we could have gotten to that node.

## 4. Pseudocode

```
SHORTEST-PATH(graph, start_vertex)

distance list: all set to infinity except the start_vertex, which is set to 0
predecessor list: all set to infinity
unvisited list: all nodes are currently unvisited, so all nodes will be in this list to start

while there are still unvisited vertexes:
    for edge of smallest distance vertex that is unvisited:
        if distance of smallest distance vertex + weight of edge < distance of target vertex:
            replace distance of target vertex with smaller distance
            make predecessor of target vertex the current vertex
    set smallest distance vertex to visited

    

```

## 5. Inputs & Outputs

Inputs: graph (Graph class) includes vertexes and edges alongside various functions
start_vertex (int) the output includes the smallest distance from your start_vertex to every other vertex, so start_vertex is whichever vertex you want that info on

Outputs: distance (list of ints) Total distance from start_vertex to every vertex in graph
pred (list of ints) The predecessor of each vertex. The previous vertex you were at before this one to make the shortest path. When combined, can trace the path from start_vertex to any vertex to find the path it took to get there.

## 6. Analysis Results

* Worst Case: $O(V^2)$

* Best Case: $\Omega(E+VlogV)$

