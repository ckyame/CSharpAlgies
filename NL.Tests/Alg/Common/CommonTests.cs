using System.Collections;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using NL.Alg.Common;

namespace NL.Tests.Alg.Common
{
    [TestClass]
    public class CommonTests
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

        [TestMethod]
        public void CanSwapList()
        {
            List<int> swaping = new List<int>() {1, 2};
            swaping.Swap(0, 1);
            Assert.IsTrue(swaping[0] == 2);
        }

        [TestMethod]
        public void CanSwapArray()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Swap(0, 1);
            Assert.IsTrue((int)array[0] == 2);
        }

        [TestMethod]
        public void CanPopulate()
        {
            List<int> populate = new List<int>(10);
            populate.Populate(1);
            populate.ForEach(p => Assert.AreEqual(1, p));
        }
    }
}
