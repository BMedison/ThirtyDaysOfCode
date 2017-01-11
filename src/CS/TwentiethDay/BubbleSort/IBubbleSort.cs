using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentiethDay.BubbleSort
{
    public interface IBubbleSort
    {
        int[] Sort(int[] a);
        int GetTotalNumOfSwaps();
    }
}
