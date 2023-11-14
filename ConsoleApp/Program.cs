using System;
using System.Collections.Generic;
using System.Linq;
using SearchAlg;
using SortAlg;
using RecursiveAlg;
using RecursiveAlg.RecursiveSummArray;

namespace ConsoleApp;

public class Program
{
    public static void Main()
    {
        //TestCoses.BinarySearchTest();
        //TestCoses.SelectionSortTest();
        //TestCoses.RecursiveSummArrayTest();
        //TestCoses.RecursiveCountElementArrayTest();
        //TestCoses.RecursiveSearchMaxElementTest();
        
    }

    internal static class TestCoses
    {
        public static void RecursiveSearchMaxElementTest()
        {
            var max = RecursiveSearchMaxElement
                    .RecursiveSearchMaxElementFunc
                    (new[] {1, 2 , 3, 4, 5, -2, 4, 2, 1});
            Console.WriteLine(max);
        }

        public static void RecursiveCountElementArrayTest()
        {
            var summ = RecursiveCountElementArray
            .RecursiveCountElementArrayFunc(new[] {1, 2 , 3, 4, 5});
            Console.WriteLine(summ);
        }

        public static void RecursiveSummArrayTest()
        {
            var summ = RecursiveSummArray.RecursiveSummArrayFunc(new[] {1, 2 , 3, 4, 5});
            Console.WriteLine(summ);
        }

        public static void SelectionSortTest()
        {
            int[] testArr = {1, 3, 5, 7, 9};
            List<int> testList = new List<int>(testArr);
            
            foreach(var val in testList)
            {
                Console.Write(val + " ");
            }
        }

        public static void BinarySearchTest()
        {
            var testArr = new[] {1, 3, 5, 7, 9};
            Console.WriteLine(BinarySearch<int>.BinarySearchFunc(1, testArr));
            Console.WriteLine(BinarySearch<int>.BinarySearchFunc(4, testArr));
        }
    }
}
