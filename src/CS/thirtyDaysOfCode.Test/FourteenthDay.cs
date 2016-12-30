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
        public void FourteenthDayTest1()
        {
            Convert.ToInt32("3");

            int[] a = "1 2 5".Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Assert.AreEqual(4, d.maximumDifference);
        }

        [TestMethod]
        public void FourteenthDayTest2()
        {
            Convert.ToInt32("5");

            int[] a = "8 19 3 2 7".Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Assert.AreEqual(17, d.maximumDifference);
        }

        [TestMethod]
        public void FourteenthDayTest3()
        {
            Convert.ToInt32("5");

            int[] a = "8 8 8 8 8".Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Assert.AreEqual(0, d.maximumDifference);
        }
    }
}
