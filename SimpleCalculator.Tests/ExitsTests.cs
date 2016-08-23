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

        [TestMethod]
        public void CanItExit()
        {
            Assert.IsTrue(TestExits.Exit("quit"));
            Assert.IsTrue(TestExits.Exit("exit"));
            Assert.IsFalse(TestExits.Exit("This should fail"));
        }
    }
}
