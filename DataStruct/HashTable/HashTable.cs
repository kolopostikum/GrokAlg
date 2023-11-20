using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace DataStruct.HashTable
{
    public class HashTable<T>
    {
        private LinkedList<T>[] hashArray;
        private int fullness;
        private Func<T, int> GetHashCodeLocal;

        public HashTable(Func<T, int> GetHashCode)
        {
            hashArray = new LinkedList<T>[100];
            fullness = 0;
            this.GetHashCodeLocal = GetHashCode;
        }

        public HashTable(IEnumerable<T> values, Func<T, int> GetHashCode)
        {
            hashArray = new LinkedList<T>[values.Count()];
            fullness = 0;
            this.GetHashCodeLocal = GetHashCode;
            foreach (var value in values)
                AddValueToHash(value);
        }

        public void AddValueToHash(T value)
        {
            if (fullness / hashArray.Length > 0.7)
                AddEmptyCells();
            var index = this.GetHashCodeLocal(value);
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
    }
}