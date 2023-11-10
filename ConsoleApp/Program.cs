using System;
using System.Collections.Generic;
using System.Linq;
using SearchAlg;

namespace ConsoleApp;

public class Program
{
    public static void Main()
    {
        BinarySearchTest();
    }

    private static void BinarySearchTest()
    {
        var testArr = new[] {1, 3, 5, 7, 9};
        Console.WriteLine(BinarySearch<int>.BinarySearchFunc(1, testArr));
        Console.WriteLine(BinarySearch<int>.BinarySearchFunc(4, testArr));
    }
}
