using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void CanCreateAnInstance()
        {
            Assert.IsNotNull(TestExpression);
        }
}
