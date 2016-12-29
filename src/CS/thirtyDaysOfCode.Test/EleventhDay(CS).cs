using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

using EleventhDay;

namespace thirtyDaysOfCode.Test
{
    [TestClass]
    public class EleventhDayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] str = new string[6];
            str[0] = "0 -4 -6 0 -7 -6\n";
            str[1] = "-1 -2 -6 -8 -3 -1\n";
            str[2] = "-8 -4 -2 -8 -8 -6\n";
            str[3] = "-3 -1 -2 -5 -7 -4\n";
            str[4] = "-3 -5 -3 -6 -6 -6\n";
            str[5] = "-3 -6 0 -8 -6 -7\n";
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = str[arr_i].Split(' ');
                arr[arr_i] = arr_temp.Select(x => Convert.ToInt32(x)).ToArray();
            }

            List<int[,]> arrs = BigMatrix.SeparateMatrix(arr);
            int max = -999;
            foreach (var item in arrs)
            {
                int res = Hourglass.Calculate(item);
                if (res > max)
                    max = res;
            }

            Assert.AreEqual(-19, max);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] str = new string[6];
            str[0] = "1 1 1 0 0 0\n";
            str[1] = "0 1 0 0 0 0\n";
            str[2] = "1 1 1 0 0 0\n";
            str[3] = "0 0 2 4 4 0\n";
            str[4] = "0 0 0 2 0 0\n";
            str[5] = "0 0 1 2 4 0\n";
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = str[arr_i].Split(' ');
                arr[arr_i] = arr_temp.Select(x => Convert.ToInt32(x)).ToArray();
            }

            List<int[,]> arrs = BigMatrix.SeparateMatrix(arr);
            int max = -999;
            foreach (var item in arrs)
            {
                int res = Hourglass.Calculate(item);
                if (res > max)
                    max = res;
            }

            Assert.AreEqual(19, max);
        }
    }
}
