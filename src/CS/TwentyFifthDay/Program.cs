using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void ShowResult(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i] == 1 ? "Prime" : "Not prime");
        }
    }

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //        10
        //1000000000 Not prime
        //1000000001 Not prime
        //1000000002 Not prime
        //1000000003 Not prime
        //1000000004 Not prime
        //1000000005 Not prime
        //1000000006 Not prime
        //1000000007 Prime
        //1000000008 Not prime
        //1000000009 Prime

        var count = int.Parse(Console.ReadLine());
        int[] iArr = new int[count];

        for(var i = 0; i < count; i++)
        {
            int a = int.Parse(Console.ReadLine());
            var s = false;
            switch (a)
            {
                case 0:
                    iArr[i] = -1;
                    s = true;
                break;
                case 1:
                    iArr[i] = 0;
                    s = true;
                break;
                case 2:
                case 3:
                    iArr[i] = 1;
                    s = true;
                break;
                default:
                break;
            }
            if (s)
                continue;

            if ((a % 2) == 0)
            {
                iArr[i] = 0;
                continue;
            }

            var c = (int)Math.Ceiling(Math.Sqrt(a));
            for(var d = 3; d <= c; d += 2)
            {
                if((a % d) == 0)
                {
                    iArr[i] = 0;
                    break;
                }else
                {
                    iArr[i] = 1;
                    continue;
                }
            }
        }

        ShowResult(iArr);
        Console.ReadLine();
    }
}
