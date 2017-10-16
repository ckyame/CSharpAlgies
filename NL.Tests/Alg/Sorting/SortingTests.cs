using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NL.Alg.Sorting;

namespace NL.Tests.Alg.Sorting
{
    [TestClass]
    public class SortingTests
    {
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

        List<int> NUMBERS = new List<int> { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
        List<int> ASCEXPECTED = new List<int> { 0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 46, 55 };
        List<int> DECEXPECTED = new List<int> { 55, 46, 42, 34, 25, 23, 16, 15, 12, 9, 8, 4, 3, 2, 0 };

        #region Assertion

        private void AssertResults<T>(List<T> expected, List<T> actual)
        {
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        #endregion

        #region BST Tests

        [TestMethod]
        public void CanSortUnbalancedBST()
        {
            NUMBERS.UnbalancedBSTSort<int>();
            AssertResults(ASCEXPECTED, NUMBERS);
        }

        #endregion

        #region Bubble Tests

        [TestMethod]
        public void CanBubbleSort()
        {
            NUMBERS.BubbleSort();
            AssertResults(ASCEXPECTED, NUMBERS);
        }

        [TestMethod]
        public void CanDecBubbleSort()
        {
            NUMBERS.BubbleSortDescending(Comparer<int>.Default);
            AssertResults(DECEXPECTED, NUMBERS);
        }

        [TestMethod]
        public void CanAscBubbleSort()
        {
            NUMBERS.BubbleSortAscending(Comparer<int>.Default);
            AssertResults(ASCEXPECTED, NUMBERS);
        }

        #endregion

        #region Bucket Tests

        [TestMethod]
        public void CanBucketSort()
        {
            NUMBERS.BucketSort();
            AssertResults(ASCEXPECTED, NUMBERS);
        }

        [TestMethod]
        public void CanDecBucketSort()
        {
            NUMBERS.BucketSortDescending();
            AssertResults(DECEXPECTED, NUMBERS);
        }

        [TestMethod]
        public void CanAscBucketSort()
        {
            NUMBERS.BucketSortAscending();
            AssertResults(ASCEXPECTED, NUMBERS);
        }

        #endregion

        #region LSD Radix Tests

        [TestMethod]
        public void CanRadixSort()
        {
            string test = "bjhdamnc";
            string result = test.LSDRadixSort();
            Assert.AreEqual("abcdhjmn", result);
        }

        [TestMethod]
        public void CanRadixSortHandleDuplicates()
        {
            string test = "bjhhaijdfn";
            string result = test.LSDRadixSort();
            Assert.AreEqual("abdfhhijjn", result);
        }

        #endregion

        #region Merge Tests

        [TestMethod]
        public void CanDoMergeSort()
        {
            var result = NUMBERS.MergeSort();
            AssertResults(ASCEXPECTED, result);
        }

        #endregion

        #region Odd Even Tests

        [TestMethod]
        public void CanDoOddEventSort()
        {
            NUMBERS.OddEvenSort();
            AssertResults(ASCEXPECTED, NUMBERS);
        }

        [TestMethod]
        public void CanDoDecOddEvenSort()
        {
            NUMBERS.OddEvenSortDescending(Comparer<int>.Default);
            AssertResults(DECEXPECTED, NUMBERS);
        }

        [TestMethod]
        public void CanDoAscOddEvenSort()
        {
            NUMBERS.OddEvenSortAscending(Comparer<int>.Default);
            AssertResults(ASCEXPECTED, NUMBERS);
        }

        #endregion
    }
}
