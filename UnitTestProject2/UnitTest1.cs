using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {

            double vklad = 10000;
            int procent = 10;
            double expented = 10000;

            double actual = ArraySearch.Discount(vklad,procent );
            Assert.AreEqual(expented, actual);
        }
    }
}
