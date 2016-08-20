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
    }
}
