using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {

        Calculator TestCalculator = new Calculator();

        [TestMethod]
        public void CanICreateAnInstance()
        {
            Assert.IsNotNull(TestCalculator);
        }

        [TestMethod]
        public void CanItAdd()
        {
            int First = 4, Second = 8;

            Assert.AreEqual(TestCalculator.Add(First, Second), 12);
        }

    [TestMethod]
    public void CanItSubtract()
    {
        int First = 7, Second = 4;

        Assert.AreEqual(TestCalculator.Subtract(First, Second), 3);
    }

    [TestMethod]
    public void CanItMultiply()
    {
        int First = 3, Second = 5;

        Assert.AreEqual(TestCalculator.Multiply(First, Second), 15);
    }

    [TestMethod]
    public void CanItDivide()
    {
        int First = 9, Second = 3;

        Assert.AreEqual(TestCalculator.Divide(First, Second), 3);
    }

    [TestMethod]
    public void CanModulus()
    {
        int First = 6, Second = 4;

    Assert.AreEqual(TestCalculator.Modulus(First, Second), 2);
    }
    
    }
}
