using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FifteenthDay;

namespace thirtyDaysOfCode.Test
{
    [TestClass]
    public class FifteenthDay
    {
        [TestMethod]
        public void FifteenthDayTest1()
        {
            Node head = null;
            int T = Int32.Parse("4");
            int data = 0;
            data = Int32.Parse("2");
            head = Program.insert(head, data);
            data = Int32.Parse("3");
            head = Program.insert(head, data);
            data = Int32.Parse("4");
            head = Program.insert(head, data);
            data = Int32.Parse("1");
            head = Program.insert(head, data);
            Assert.AreEqual(2, head.data);
        }
    }
}
