using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortAlg
{
    /// <summary>
    /// Класс, реализующий сортировку выбором.
    /// </summary>
    public static class SelectionSort<T>
    where T : IComparable<T> 
    {
        /// <summary>
        /// Сортировка выбором (англ. selection sort) — алгоритм сортировки.
        /// Может быть как устойчивый, так и неустойчивый.
        /// На массиве из n элементов имеет время выполнения в худшем,
        /// среднем и лучшем случаеO(n^{2}),
        /// предполагая что сравнения делаются за постоянное время.
        /// </summary>
        ///<param name="item">Искомый элемент.</param>
        ///<param name="sortedArray">Отсортированный массив элементов.</param>
        /// <returns>Индекс искомого элемента или null при его отсутствии.</returns>
        
        public static List<T> SelectionSortFunc (List<T> unsortedArray)
        {
            var sortedArray = new List<T>();
            var length = unsortedArray.Count();

            for (int i = 0; i < length; i++)
            {
                var smalles = FindSmallest(unsortedArray);
                unsortedArray.Remove(smalles);
                sortedArray.Add(smalles);
            }

            return sortedArray;
        }

        private static T FindSmallest(List<T> unsortedArray)
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