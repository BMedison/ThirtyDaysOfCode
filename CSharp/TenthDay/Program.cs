using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
//            int n = Convert.ToInt32(Console.ReadLine());
            int n = 65535;
            List<int> bits = new List<int>();
            
            while(n > 0) {
                if(n % 2 == 0) {
                    bits.Add(0);
                }else {
                    bits.Add(1);
                }
                n = n / 2 | 0;
            }
            
            int cur_count = 0;
            int prev_count = 0;
            foreach(var i in bits) {
                if(i == 0) {
                    if(cur_count > prev_count)
                        prev_count = cur_count;
                    cur_count = 0;
                }else
                    ++cur_count;
            }

            if(cur_count <= prev_count)
                cur_count = prev_count;
            Console.WriteLine(cur_count);
        }
    }
}
