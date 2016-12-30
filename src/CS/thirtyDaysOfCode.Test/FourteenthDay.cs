using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using FourteenthDay;

namespace thirtyDaysOfCode.Test
{
    [TestClass]
    public class FourteenthDay
    {
        [TestMethod]
        public void TestMethod1()
        {
            Convert.ToInt32("3");

            int[] a = "1 2 5".Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Assert.AreEqual(4, d.maximumDifference);
        }
    }
}
