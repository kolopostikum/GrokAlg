using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecursiveAlg
{
    public class RecursiveSearchMaxElement
    {
        public static int RecursiveSearchMaxElementFunc(int[] array, int index = 0)
        {
            if(index == array.Length)
                return int.MinValue;
            return int.Max(array[index], RecursiveSearchMaxElementFunc(array, index + 1));
        }
    }
}