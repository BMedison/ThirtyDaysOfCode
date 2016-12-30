using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FourteenthDay
{
    [TestFixture]
    public class FourteenthDay
    {
        [Test]
        public void TestMethod1()
        {
            Convert.ToInt32("3");

            int[] a = "1 2 5".Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Assert.AreEqual(d.maximumDifference, 4);
        }
    }

    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
        }

        public int ComputeDifference()
        {
            return maximumDifference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
