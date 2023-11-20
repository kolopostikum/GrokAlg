using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace DataStruct.HashTable
{
    public class HashTable<T>
    {
        private LinkedList<T>[] hashArray;
        private int fullness;

        public HashTable()
        {
            hashArray = new LinkedList<T>[100];
            fullness = 0;
        }

        public HashTable(IEnumerable<T> values)
        {
            hashArray = new LinkedList<T>[values.Count()];
            fullness = 0;
            foreach (var value in values)
                AddValueToHash(value);
        }

        public void AddValueToHash(T value)
        {
            if (fullness / hashArray.Length > 0.7)
                AddEmptyCells();
            var index = value.GetHashCode();
            if (hashArray[index] == null)
            {
                hashArray[index] = new LinkedList<T>();
                hashArray[index].AddLast(value);
                fullness++;
            }
            else
            {
                if (!hashArray[index].Any())
                    fullness++;
                if (hashArray[index].Contains(value))
                    return;
                hashArray[index].AddLast(value);
            }
        }

        private void AddEmptyCells()
        {
            var newHashArray = new LinkedList<T>[hashArray.Length * 2];
            hashArray.CopyTo(newHashArray, 0);
            hashArray = newHashArray;
        }

        public LinkedList<T> this[T key]
        {
            get { return hashArray[key.GetHashCode()]; }
        }

        public bool Contains(T key) 
        {
            if (hashArray.Length <= key.GetHashCode())
                return false;
            if (hashArray[key.GetHashCode()] == null)
                return false;
            return true;
        }
    }
}