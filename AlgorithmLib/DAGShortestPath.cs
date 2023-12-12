using System.Runtime.CompilerServices;

namespace AlgorithmLib;


public static class DAGShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        //have the sorted list, the distance from the start list, and the pred list, which keeps track of which vertex came before it.
        var sorted = DAGTopologicalSort.Sort(g);
        var distance = Enumerable.Repeat(Graph.INF, sorted.Count).ToList();
        var pred = Enumerable.Repeat(Graph.INF, sorted.Count).ToList();

        distance[startVertex] = 0;

        foreach (var vertex in sorted)
        {
            //this if statement makes it skip over any vertexes that aren't on the path from the start vertex to the end vertex
            if (distance[vertex] != Graph.INF)
            {
                foreach (var edge in g.Edges(vertex))
                {
                    //if this new path is shorter than a previous one, it replaces it
                    if (distance[vertex] + edge.Weight < distance[edge.DestId])
                    {
                        distance[edge.DestId] = distance[vertex] + edge.Weight;
                        pred[edge.DestId] = vertex;
                    }
                }
            }
        }
        
        return (distance, pred);
    } 
    
}