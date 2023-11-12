using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAlg
{
    public static class SearchSmallest<T>
    where T : IComparable<T> 
    {
        /// <summary>
        /// Поиск наименьшего элемента неотсортированного массива.
        /// </summary>
        /// <param name="unsortedArray">Неотсортированный массив.</param>
        /// <returns>Наименьший элемент</returns>
        public static T FindSmallest(List<T> unsortedArray)
        {
            var smallest = unsortedArray[0];
            var smallestIndex = 0;
            var length = unsortedArray.Count();

            for (int i = 0; i < length; i++)
                if (smallest.CompareTo(unsortedArray[i]) < 0)
                {
                    smallest = unsortedArray[i];
                    smallestIndex = i;
                }

            return smallest;
        }
    }
}