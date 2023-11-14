using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecursiveAlg.RecursiveSummArray
{
    public class RecursiveSummArray
    {
        public static int RecursiveSummArrayFunc(int[] array, int index = 0)
        {
            if(index == array.Length)
                return 0;
            return array[index] + RecursiveSummArrayFunc(array, index + 1);
        }
    }
}