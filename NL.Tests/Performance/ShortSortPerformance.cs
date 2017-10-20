using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NL.Alg.Sorting;

namespace NL.Tests.Performance
{
    /// <summary>
    /// Summary description for ShortSortPerformancecs
    /// </summary>
    [TestClass]
    public class ShortSortPerformance
    {
        private List<int> TestSet = new List<int>()
        {
            1,
            55,
            98,
            81,
            70,
            22,
            83,
            72,
            56,
            91,
            62,
            73,
            96,
            59,
            42,
            82,
            34,
            91,
            15,
            88,
            85,
            98,
            37,
            26,
            35
        };

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        [TestMethod]
        public void BSTTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.UnbalancedBSTSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.BubbleSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void BucketSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.BucketSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void CombSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.CombSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void CountingSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.CountingSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void CycleSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.CycleSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void GnomeSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.GnomeSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.InsertionSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.MergeSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void OddEvenSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.OddEvenSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void PigeonHoleSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.PigeonHoleSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void QuickSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.BubbleSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.SelectionSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }

        [TestMethod]
        public void ShellSortTest()
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            TestSet.ShellSort();
            timer.Stop();
            Console.WriteLine("SORT TIME " + timer.ElapsedMilliseconds);
        }
    }
}
