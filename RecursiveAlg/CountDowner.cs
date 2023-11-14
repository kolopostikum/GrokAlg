using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecursiveAlg.CountDowner
{
    public class CountDowner
    {
        public static void CountDownerRec(int num)
        {
            if (num < 0)
                return;
            Console.WriteLine(num);
            CountDownerRec(num--);
        }
    }
}