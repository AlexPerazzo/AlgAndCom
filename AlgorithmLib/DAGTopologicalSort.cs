using System.Collections;

namespace AlgorithmLib;

public static class DAGTopologicalSort
{
    public static List<int> Sort(Graph g)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var inDegree = Enumerable.Repeat(0, g.Size()).ToList();
        var linearOrder = new List<int>();

        //Each vertex has one in_degree for each vertex point at it
        for (var vertex = 0; vertex < g.Size(); vertex++)
        {
            foreach (var edge in g.Edges(vertex))
            {
                inDegree[edge.DestId] += 1;
            }
        }

        // next list will serve as our stack. Items with all predecessors already gone (or had none) will be added to this stack. They will then be taken from this stack and be put on the ordered list.
        var next = new List<int>();

        // If vertex has no in_degree, it's ready to go!
        for (var vertex = 0; vertex < g.Size(); vertex++)
        {
            if (inDegree[vertex] == 0)
            {
                next.Add(vertex);
            }
        }

        //cycle will continue until all vertexes have been added to the sorted list.
        while (next.Count > 0)
        {
            var vertex = next[^1];
            next.RemoveAt(next.Count - 1);
            linearOrder.Add(vertex);
            foreach (var edge in g.Edges(vertex))
            {
                // All of the vertexes it was attached to loses one item pointing toward it, so its in_degree decreases
                inDegree[edge.DestId] -= 1;
                
                // Check if item no longer has predecessors. If so, it's ready to be added to the list.
                if (inDegree[edge.DestId] == 0)
                {
                    next.Add(edge.DestId);
                }
            }
        }
        
        return linearOrder;
    } 
}