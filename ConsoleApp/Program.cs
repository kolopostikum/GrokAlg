using System;
using System.Collections.Generic;
using System.Linq;
using SearchAlg;
using SortAlg;
using RecursiveAlg;
using RecursiveAlg.RecursiveSummArray;
using SearchAlg.SearchWidth;
using SearchAlg.DijkstraSearch;
using System.Runtime.InteropServices;
using SearchAlg.Greedy;

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
        //TestCoses.QuickSortTest();
        //TestCoses.BFSTest();
        //TestCoses.DijkstraTest();
        TestCoses.Greedy();
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

        public static void QuickSortTest()
        {
            var sortedList = QuickSort<int>
                    .QuickSortRecursionFunc
                    (new[] {1, 2 , 3, 4, 5, -2, 4, 2, 1}.ToList());
            foreach (var item in sortedList)
            {
                Console.Write(item);
                Console.Write("||");
            }
        }

        public static void BFSTest()
        {
            var testCose = new List<LinkedList<int>> 
            {
                {new LinkedList<int>(new[] {1, 2, 3})},
                {new LinkedList<int>(new[] {2, 4, 1})},
                {new LinkedList<int>(new[] {4, 6, 7})}
            };
            BFS<int> testBFS = new BFS<int>(testCose);
            var steps = testBFS.BRSFunc(1);
            Console.Write(steps[1] + " ");            
            Console.WriteLine(steps[7] + " ");
            Console.WriteLine(steps[4]);
        }

        internal static void DijkstraTest()
        {
            var testCose = new List<(string, string, int)> 
            {
                new ("a", "b" , 3),
                new ("a", "c" , 10),                
                new ("a", "d" , 3),
                new ("d", "c" , 3),
                new ("c", "e" , 7),
                new ("b", "c" , 3)
            };
            DijkstraClass<string> testCase = new DijkstraClass<string>(testCose);  
            Console.Write(testCase.DijkstraSearch("a", "e") + " ");            
            Console.WriteLine(testCase.DijkstraSearch("a", "b"));
            Console.WriteLine(testCase.DijkstraSearch("a", "a"));
        }

        internal static void Greedy()
        {
            var testStats = new HashSet<string>
            {
                "mt", "wa", "or", "id",
                "nv", "ut", "ca", "az"
            };
            var testStations = new Dictionary<string, HashSet<string>>();
            testStations["Kone"] = new HashSet<string>{"id", "nv", "ut"};
            testStations["ktwo"] = new HashSet<string>{"wa", "id", "mt"};
            testStations["kthree"] = new HashSet<string>{"or", "nv", "ca"};
            testStations["kfour"] = new HashSet<string>{"nv", "ut"};
            testStations["kfive"] = new HashSet<string>{"ca", "az"};
            
            var greedyTest = new GreedyStation<string, string>(testStats, testStations);
            foreach (var station in greedyTest.GreedyStationsSearch())
            {
                Console.Write(station + " ");
            }
        }
    }
}
