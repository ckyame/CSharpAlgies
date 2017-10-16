using Microsoft.VisualStudio.TestTools.UnitTesting;
using NL.Alg.Compare;

namespace NL.Tests.Alg.Compare
{
    /// <summary>
    /// Unit Tests for NL.Alg.Compare
    /// </summary>
    [TestClass]
    public class CompareTests
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
        public void CanCompareNumbersToEqual()
        {
            int number1 = 1;
            int number2 = 1;
            Assert.IsTrue(NL.Alg.Compare.Compare.ValueEqualTo(number1, number2));
        }
        [TestMethod]
        public void CanCompareNumbersToEqualOnExtension()
        {
            int number1 = 1;
            int number2 = 1;
            Assert.IsTrue(number1.ValueEqualTo(number2));
        }
        [TestMethod]
        public void CanCompareEqualNumbersReturnsFalseIfNotEqual()
        {
            int number1 = 1;
            int number2 = 2;
            Assert.IsFalse(number1.ValueEqualTo(number2));
        }
        [TestMethod]
        public void CanFindGreaterNumber()
        {
            int number1 = 1;
            int number2 = 2;
            Assert.IsTrue(NL.Alg.Compare.Compare.ValueGreaterThan(number2, number1));
        }
        [TestMethod]
        public void CanFindGreaterNumberWithExtension()
        {
            int number1 = 1;
            int number2 = 2;
            Assert.IsTrue(number2.ValueGreaterThan(number1));
        }
        [TestMethod]
        public void CanFindGreaterNumberReturnsFalseIfNotGreater()
        {
            int number1 = 1;
            int number2 = 2;
            Assert.IsFalse(number1.ValueGreaterThan(number2));
        }
        [TestMethod]
        public void CanFindLesserNumber()
        {
            int number1 = 1;
            int number2 = 2;
            Assert.IsTrue(NL.Alg.Compare.Compare.ValueLessThan(number1, number2));
        }
        [TestMethod]
        public void CanFindLessWithExtensionMethod()
        {
            int number1 = 1;
            int number2 = 2;
            Assert.IsTrue(number1.ValueLessThan(number2));
        }
        [TestMethod]
        public void CanFindLessThanReturnsFalseIfNotLessThan()
        {
            int number1 = 1;
            int number2 = 2;
            Assert.IsFalse(number2.ValueLessThan(number1));
        }
    }
}
