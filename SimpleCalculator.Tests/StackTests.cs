using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        Stack TestStack = new Stack();
        public bool DoTheThing = true;

        [TestMethod]
        public void CanCreateStackInstance()
        {
            Assert.IsNotNull(TestStack);
        }

        [TestMethod]
        public void CanUseLastEq()
        {
            TestStack.LastEq("lasteq");
            Assert.IsFalse(DoTheThing);

            TestStack.LastEq("DoTheThing should return true.");
            Assert.IsTrue(DoTheThing);
        }

        [TestMethod]
        public void CheckLastAnswer()
        {
            TestStack.LastAns("lasta", 3);
            Assert.IsFalse(DoTheThing);
        }
    }
}
