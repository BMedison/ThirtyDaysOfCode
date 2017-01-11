using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineteenthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int i = 1;
            int summ = 1;

            while(i++ < n)
            {
                if (n % i == 0)
                    summ += i;
            }

            Console.WriteLine(summ);
            Console.ReadLine();
        }
    }
}
