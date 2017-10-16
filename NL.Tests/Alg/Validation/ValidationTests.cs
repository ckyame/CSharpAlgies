using Microsoft.VisualStudio.TestTools.UnitTesting;

using Validator = NL.Alg.Validation.Validation;

namespace NL.Tests.Alg
{
    [TestClass]
    public class ValidationTests
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
        public void CanDetectANumberIsANumber()
        {
            int number1 = 1;
            Assert.IsTrue(Validator.IsNumber(number1));
        }

        [TestMethod]
        public void CanDetectVariableIsNotANumber()
        {
            string number1 = "1";
            Assert.IsFalse(Validator.IsNumber(number1));
        }

        [TestMethod]
        public void CanDetectDynamicAsNumber()
        {
            dynamic number = 1;
            Assert.IsTrue(Validator.IsNumber(number));
        }

        [TestMethod]
        public void CanDetectIfString()
        {
            string str = "string";
            Assert.IsTrue(Validator.IsString(str));
        }

        [TestMethod]
        public void CanDetectIfNotAString()
        {
            int number = 1;
            Assert.IsFalse(Validator.IsString(number));
        }

        [TestMethod]
        public void CanDetectStringOnDynamicVariable()
        {
            dynamic str = "string";
            Assert.IsTrue(Validator.IsString(str));
        }

        [TestMethod]
        public void CanDetectNotAStringOnDynamicVariable()
        {
            dynamic number = 1;
            Assert.IsFalse(Validator.IsString(number));
        }

        [TestMethod]
        public void CanDetectIfStringOrNumber()
        {
            string str = "string";
            int number = 1;
            Assert.IsTrue(Validator.IsStringOrNumber(str));
            Assert.IsTrue(Validator.IsStringOrNumber(number));
        }

        [TestMethod]
        public void CanDetectIfNotStringOrNumber()
        {
            bool boolean = false;
            Assert.IsFalse(Validator.IsStringOrNumber(boolean));
        }

        [TestMethod]
        public void CanTellIfStringIsString()
        {
            string str = "string";
            Assert.IsTrue(Validator.WhatIs(str) == "String");
        }

        [TestMethod]
        public void CanTellIfNumberIsNumber()
        {
            int number = 1;
            Assert.IsTrue(Validator.WhatIs(number) == "Int32");
        }
    }
}
