using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchAlg;

public static class BinarySearch<T>
where T : IComparable<T> 
{
    public static int? BinarySearchFunc(T item, T[] sortedArray)
    {
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
