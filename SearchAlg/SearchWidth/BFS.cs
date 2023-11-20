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

        public int BRSFunc(T start, T end)
        {
            var queue = new Queue<T>();
            var steps = 0;
            HashTable<T> checkedNodes = new HashTable<T>();
            queue.Enqueue(start);
            checkedNodes.AddValueToHash(start);
            while (queue.Any())
            {
                var actualNode = queue.Dequeue();
                if (actualNode.Equals(end))
                    return steps;
                steps++;
                foreach (var value in hashTable[actualNode])
                    if (!checkedNodes.Contains(value))
                    {
                        queue.Enqueue(value);
                        checkedNodes.AddValueToHash(value);
                    }       
            }
            return -1;
        }
    }
}