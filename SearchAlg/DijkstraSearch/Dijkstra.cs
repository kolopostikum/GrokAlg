using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStruct.HashTable;

namespace SearchAlg.DijkstraSearch
{
    public class DijkstraClass<T> 
    {
        private Dictionary<T, Dictionary<T, int>> graph;

        public DijkstraClass(List<(T parent, T child, int cost)> values)
        {
            this.graph = new Dictionary<T, Dictionary<T, int>>();
            foreach (var value in values)
            {
                AddValueToGraph(value.parent, value.child, value.cost);
            }
        }

        private void AddValueToGraph(T? parent, T? child, int cost)
        {
            if (!graph.ContainsKey(parent))
                graph[parent] = new Dictionary<T, int>();
            if (!graph.ContainsKey(child))
                graph[child] = new Dictionary<T, int>();
            if (child != null)
                graph[parent][child] = cost;
        }

        public int DijkstraSearch(T start, T searchedPoint)
        {
            var costs = new Dictionary<T, int>();
            var parents = new Dictionary<T, T>();
            var checkedPoints = new HashSet<T>();
            var uncheckedPoints = new HashSet<T>();
            checkedPoints.Add(start);
            costs.Add(start, 0);
            foreach(var kid in graph[start].Keys)
            {
                costs[kid] = graph[start][kid];
                parents[kid] = start;
                uncheckedPoints.Add(kid);
            }

            while (uncheckedPoints.Any())
            {
                var minCostNode = costs
                .Where(x => uncheckedPoints.Contains(x.Key))
                .OrderBy(x => x.Value)
                .First();
                uncheckedPoints.Remove(minCostNode.Key);
                checkedPoints.Add(minCostNode.Key);
                foreach (var key in graph[minCostNode.Key].Keys)
                {
                    if (costs.ContainsKey(key))
                    {
                        if (costs[key] > minCostNode.Value + graph[minCostNode.Key][key])
                        {
                            costs[key] = minCostNode.Value + graph[minCostNode.Key][key];
                            parents[key] = minCostNode.Key;
                        }
                    }
                    else
                    {
                        costs[key] = graph[minCostNode.Key][key] + minCostNode.Value;
                        parents[key] = minCostNode.Key;
                        uncheckedPoints.Add(key);
                    }
                }

            }
            return costs[searchedPoint];
        }
    }
}