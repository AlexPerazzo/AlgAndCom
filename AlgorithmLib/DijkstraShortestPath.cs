using System.Drawing;

namespace AlgorithmLib;

public static class DijkstraShortestPath
{

    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        
        //Set lists to be set with fluff place-holders
        var distance = Enumerable.Repeat(Graph.INF, g.Size()).ToList();
        var pred = Enumerable.Repeat(Graph.INF, g.Size()).ToList();
        var priorityQueue = new PriorityQueue<int>();

        distance[startVertex] = 0;
        
        for (var index = 0; index < g.Size(); index++)
        {
            priorityQueue.Insert(index, distance[index]);
        }

        
        
        while (priorityQueue.Size() > 0)
        {

            // grab number with smallest priority (which is the first thing from the priorityQueue)
            var smallestId = priorityQueue.Dequeue();

            foreach (var edge in g.Edges(smallestId))
            {
                // If new path is smaller than previously stored, replace path with smaller path
                if (distance[smallestId] + edge.Weight < distance[edge.DestId])
                {
                    //replace shortest path
                    distance[edge.DestId] = distance[smallestId] + edge.Weight;
                    //replace predecessor
                    pred[edge.DestId] = smallestId;
                    priorityQueue.DecreaseKey(edge.DestId, distance[edge.DestId]);
                }
            }

        }
        
        return (distance, pred);
    } 
}