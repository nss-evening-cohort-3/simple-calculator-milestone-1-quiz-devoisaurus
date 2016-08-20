using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        Expression TestExpression = new Expression();
        static string pattern = @"^(?<NumOne>-?\d+)\s?(?<Oprtr>[\+\-\*\/%])\s?(?<NumTwo>-?\d+)";
        Regex Regex = new Regex(pattern);

        [TestMethod]
        public void CanCreateAnInstance()
        {
            Assert.IsNotNull(TestExpression);
        }

        [TestMethod]
        public void CanCheckInput()
        {
            string test01 = "1+1";
            string test02 = "4-3";
            string test03 = "5*5";
            string test04 = "4/2";
            string test05 = "12/3";
            string test06 = "nope";

            Assert.IsTrue(Regex.IsMatch(test01));
            Assert.IsTrue(Regex.IsMatch(test02));
            Assert.IsTrue(Regex.IsMatch(test03));
            Assert.IsTrue(Regex.IsMatch(test04));
            Assert.IsTrue(Regex.IsMatch(test05));
            Assert.IsFalse(Regex.IsMatch(test06));


        }
    }
}