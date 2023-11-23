using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace SearchAlg.DinamicSearch
{
    /// <summary>
    ///Christy is interning at HackerRank.
    ///One day she has to distribute some chocolates to her colleagues.
    ///She is biased towards her friends and plans to give them more than the others.
    ///One of the program managers hears of this
    ///and tells her to make sure everyone gets the same number.
    ///To make things difficult, 
    ///she must equalize the number of chocolates in a series of operations.
    ///For each operation, she can give 1, 2 or 5 pieces to all but one colleague.
    ///Everyone who gets a piece in a round receives the same number of pieces.
    ///Given a starting distribution, calculate the minimum number of operations
    ///needed so that every colleague has the same number of pieces.
    /// </summary>
    public class EqualsFromHackerrank
    {
        public static int Equal(List<int> arr)
        {
            var posibilites = new int[5];
            var min = arr.Min();
            for (int i = 0; i < 5; i++)
            {
                foreach (var item in arr)
                {
                    var dif = item - min;
                    var steps5 = dif/5;
                    var steps2 = (dif%5)/2;
                    var steps1 = ((dif % 5) % 2) / 1;
                    posibilites[i] += steps5 + steps1 + steps2;  
                }
                min--;
            }
            return posibilites.Min();
        }
    }
}