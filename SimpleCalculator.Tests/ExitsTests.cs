using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExitsTests
    {
        Exits TestExits = new Exits();

        [TestMethod]
        public void CanCreateExitInstance()
        {
            Assert.IsNotNull(TestExits);
        }

    }
}
