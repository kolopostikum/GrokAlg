using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SearchAlg;

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
        ///<param name="unsortedArray">Сортируемый массив.</param>
        /// <returns>Отсортированный массив.</returns>
        
        public static List<T> SelectionSortFunc (List<T> unsortedArray)
        {
            var sortedArray = new List<T>();
            var length = unsortedArray.Count();

            for (int i = 0; i < length; i++)
            {
                var smalles = SearchSmallest<T>.FindSmallest(unsortedArray);
                unsortedArray.Remove(smalles);
                sortedArray.Add(smalles);
            }

            return sortedArray;
        }
    }
}