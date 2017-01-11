using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TwentiethDay.BubbleSort;

namespace TwentiethDay
{
    class TwentiethDay
    {
        static void Main(string[] args)
        {
            //int[] a = new int[3] { 3, 2, 1 };
            int[] a = new int[3] { 1, 2, 3 };

            IBubbleSort bs = new BubbleSortOne();
            int[] b = bs.Sort(a);
            Console.WriteLine($"Array is sorted in {bs.GetTotalNumOfSwaps()} swaps.");
            Console.WriteLine($"First Element: {b[0]}");
            Console.WriteLine($"Last Element: {b[b.Length - 1]}");
        }
    }
}
