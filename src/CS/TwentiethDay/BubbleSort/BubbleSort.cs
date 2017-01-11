using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentiethDay.BubbleSort
{
    public class BubbleSortOne : IBubbleSort
    {
        private int _totalnumOfSwaps = 0;
        private void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public BubbleSortOne() { }
        public int[] Sort(int[] a)
        {
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;

                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        swap(ref a[j], ref a[j + 1]);
                        numberOfSwaps++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }

                _totalnumOfSwaps += numberOfSwaps;
            }

            return a;
        }

        public int GetTotalNumOfSwaps()
        {
            return _totalnumOfSwaps;
        }
    }
}
