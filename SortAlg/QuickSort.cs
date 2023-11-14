using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortAlg
{
    /// <summary>
    /// Класс, реализующий быструю сортировку.
    /// </summary>
    public class QuickSort<T>
    where T: IComparable<T>
    {
        /// <summary>
        ///Быстрая сортировка — эффективный алгоритм сортировки на месте,
        ///который обычно работает примерно в два-три раза быстрее,
        ///чем Сортировка слиянием а также сортировка кучей при хорошей реализации.
        ///Быстрая сортировка — это сортировка сравнением,
        ///то есть она может сортировать элементы любого типа,
        ///для которых меньше, чем отношение определено.
        ///В эффективных реализациях это обычно нестабильная сортировка.
        /// </summary>
        ///<param name="values">Сортируемый массив.</param>
        /// <returns>Отсортированный массив.</returns>
        public static List<T> QuickSortRecursionFunc(List<T> values)
        {
            if (values.Count == 0 || values.Count == 1)
                return values;
                
            var pivot = values.FirstOrDefault();
            var less = values.Where(x => x.CompareTo(pivot) <= 0).ToList();
            var greater = values.Where(x => x.CompareTo(pivot) > 0).ToList();
            
            var subResult = QuickSortRecursionFunc(less);
            subResult.Add(pivot);
            subResult.AddRange(QuickSortRecursionFunc(greater));
            
            return subResult; 
        }
    }
}