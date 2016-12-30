using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourteenthDay
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            this.elements = a;
        }

        public void ComputeDifference()
        {
            int res = 0;
            int max = this.elements.Max();
            int min = this.elements.Min();

            res = Math.Abs(max - min);
            this.maximumDifference = res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32("3");

            int[] a = "1 2 5".Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();
        }
    }
}
