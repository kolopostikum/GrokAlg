using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecursiveAlg
{
    public class RecursiveCountElementArray
    {
        public static int RecursiveCountElementArrayFunc(int[] array, int index = 0)
        {
            try
            {
                var element = array[index];
                return 1 + RecursiveCountElementArrayFunc(array, index + 1);
            }
            catch
            {
                return 0;
            }
        }
    }
}