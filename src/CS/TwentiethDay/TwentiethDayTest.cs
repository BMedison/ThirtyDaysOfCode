using NUnit.Framework;

using TwentiethDay.BubbleSort;

namespace TwentiethDay
{
    [TestFixture]
    class TwentiethDayTest
    {
        private IBubbleSort bs;

        [SetUp]
        public void Setup()
        {
            bs = new BubbleSortOne();
        }

        [Test]
        public void SortingTest()
        {
            int[] a = new int[3] { 3, 2, 1 };
//            int[] a = new int[3] { 1, 2, 3 };
            int[] b = bs.Sort(a);
            Assert.AreEqual(new int[]{ 1, 2, 3 }, b);
            Assert.AreEqual(1, b[0]);
            Assert.AreEqual(3, b[b.Length - 1]);
        }
    }
}
