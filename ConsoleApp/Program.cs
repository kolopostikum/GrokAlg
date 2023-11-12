using System;
using System.Collections.Generic;
using System.Linq;
using SearchAlg;
using SortAlg;

namespace ConsoleApp;

public class Program
{
    public static void Main()
    {
        //BinarySearchTest();
        SelectionSortTest();
    }

    private static void SelectionSortTest()
    {
        int[] testArr = {1, 3, 5, 7, 9};
        List<int> testList = new List<int>(testArr);
        
        foreach(var val in testList)
        {
            Console.Write(val + " ");
        }
    }

    private static void BinarySearchTest()
    {
        var testArr = new[] {1, 3, 5, 7, 9};
        Console.WriteLine(BinarySearch<int>.BinarySearchFunc(1, testArr));
        Console.WriteLine(BinarySearch<int>.BinarySearchFunc(4, testArr));
    }
}
