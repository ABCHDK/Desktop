using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AssertNum1() 
        {
            Assert.AreEqual(125, new Algoritm().GetPowerNum(5,3));
        }
        public void AssertNum2() 
        {
            Assert.AreEqual(1, new Algoritm().GetPowerNum(125, 0));
        }
    }
}
