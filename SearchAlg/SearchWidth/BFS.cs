using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStruct;
using DataStruct.HashTable;

namespace SearchAlg.SearchWidth
{
    public class BFS<T>
    {
        private HashTable<T> hashTable;
        public BFS(List<LinkedList<T>> values)
        {
            hashTable = new HashTable<T>();
            foreach (var value in values)
            {
                var key = value.First();
                value.RemoveFirst();
                hashTable.AddValueToHash(key);
                foreach (var node in value)
                {    
                    hashTable[key].AddLast(node);
                    hashTable.AddValueToHash(node);
                }
            }
        }

        public Dictionary<T,int> BRSFunc(T start)
        {
            var queue = new Queue<T>();
            HashTable<T> checkedNodes = new HashTable<T>();
            Dictionary<T, int> steps = new Dictionary<T, int>();
            queue.Enqueue(start);
            checkedNodes.AddValueToHash(start);
            steps.Add(start, 0);
            while (queue.Any())
            {
                var actualNode = queue.Dequeue();
                foreach (var value in hashTable[actualNode])
                    if (!checkedNodes.Contains(value))
                    {
                        queue.Enqueue(value);
                        checkedNodes.AddValueToHash(value);
                        steps.Add(value, steps[actualNode] + 1);
                    }       
            }
            return steps;
        }
    }
}