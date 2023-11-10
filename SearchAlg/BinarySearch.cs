using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchAlg;
/// <summary>
/// Класс, реализующий бинарный поиск.
/// </summary>
public static class BinarySearch<T>
where T : IComparable<T> 
{
    /// <summary>
    /// Бинарным (или двоичным) называют поиск элемента упорядоченного множества через многократное
    /// деление этого множества пополам. Искомый элемент всегда будет оказываться в одной
    /// из двух частей.
    /// Поиск прекращается, когда обнаруживается совпадение граничного элемента
    /// между двумя разделенными блоками с заданным,
    /// или когда заданный элемент не обнаруживается вовсе.
    ///Реализация этого метода возможна только применимо к отсортированным множествам.
    /// </summary>
    ///<param name="item">Искомый элемент.</param>
    ///<param name="sortedArray">Отсортированный массив элементов.</param>
    /// <returns>Индекс искомого элемента или null при его отсутствии.</returns>
    public static int? BinarySearchFunc(T item, T[] sortedArray)
    {
        ///
        var low = 0;
        var high = sortedArray.Length - 1;
        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = sortedArray[mid];
            if (item.Equals(guess))
                return mid;
            if (guess.CompareTo(item) > 0)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return null;
    }
}
