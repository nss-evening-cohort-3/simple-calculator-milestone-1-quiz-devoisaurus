using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        Expression TestExpression = new Expression();
        string TestString = "-42";

        [TestMethod]
        public void CanCreateAnInstance()
        {
            Assert.IsNotNull(TestExpression);
        }

        [TestMethod]
        public void CanCheckForNegative()
        {
            Assert.IsTrue(TestString.StartsWith("-"));
        }

        [TestMethod]
        public void CanAddHyphen()
        {
            TestExpression.Splitter(TestString);
            Assert.AreEqual(TestExpression.One, "-");
        }

        [TestMethod]
        public void CanRemoveHyphen()
        {
            TestExpression.Splitter(TestString);
            Assert.AreEqual(TestString, "42");
        }
    }
}