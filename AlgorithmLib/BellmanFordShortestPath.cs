namespace AlgorithmLib;

public static class BellmanFordShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var distance = Enumerable.Repeat(Graph.INF, g.Size()).ToList();
        var pred = Enumerable.Repeat(Graph.INF, g.Size()).ToList();
        distance[startVertex] = 0;

        for (var i = 0; i < g.Size(); i++)
        {
            var changesMade = false;

            for (var node = 0; node < g.Size(); node++)
            {
                foreach (var edge in g.Edges(node))
                {
                    if (distance[node] + edge.Weight < distance[edge.DestId])
                    {
                        changesMade = true;
                        distance[edge.DestId] = distance[node] + edge.Weight;
                        pred[edge.DestId] = node;
                    }
                }
            }

            if (!changesMade)
            {
                Console.WriteLine($"Exiting at i={i}");
                break;
            }
        }
        
        return (distance, pred);
        

    } 
}