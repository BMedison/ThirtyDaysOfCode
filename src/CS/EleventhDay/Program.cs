using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class BigMatrix
{
    public static List<int[,]> SeparateMatrix(int[][] bigMatrix)
    {
        int x = bigMatrix.GetLength(0);
        int y = bigMatrix[0].GetLength(0);
        List<int[,]> sm = new List<int[,]>();
        for(int ix = 0; ix <= x - 3; ix++)
        {
            for (int iy = 0; iy <= y - 3; iy++)
            {
                int[,] small_matrix = new int[3, 3];
                small_matrix[0,0] = bigMatrix[ix + 0][iy + 0];
                small_matrix[0,1] = bigMatrix[ix + 0][iy + 1];
                small_matrix[0,2] = bigMatrix[ix + 0][iy + 2];
                small_matrix[1,0] = bigMatrix[ix + 1][iy + 0];
                small_matrix[1,1] = bigMatrix[ix + 1][iy + 1];
                small_matrix[1,2] = bigMatrix[ix + 1][iy + 2];
                small_matrix[2,0] = bigMatrix[ix + 2][iy + 0];
                small_matrix[2,1] = bigMatrix[ix + 2][iy + 1];
                small_matrix[2,2] = bigMatrix[ix + 2][iy + 2];
                sm.Add(small_matrix);
            }
        }
        return sm;
    }
}

public class Hourglass
{
    public static int Calculate(int[,] matrix)
    {
        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
            return matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[1, 1] + matrix[2, 0] + matrix[2, 1] + matrix[2, 2];
        else
            return -999;
    }
}

class EleventhDay
{
    static void Main(string[] args)
    {
        string[] str = new string[6];
        //str[0] = "1 1 1 0 0 0\n";
        //str[1] = "0 1 0 0 0 0\n";
        //str[2] = "1 1 1 0 0 0\n";
        //str[3] = "0 0 2 4 4 0\n";
        //str[4] = "0 0 0 2 0 0\n";
        //str[5] = "0 0 1 2 4 0\n";
        str[0] = "0 -4 -6 0 -7 -6\n";
        str[1] = "-1 -2 -6 -8 -3 -1\n";
        str[2] = "-8 -4 -2 -8 -8 -6\n";
        str[3] = "-3 -1 -2 -5 -7 -4\n";
        str[4] = "-3 -5 -3 -6 -6 -6\n";
        str[5] = "-3 -6 0 -8 -6 -7\n";
        int[][] arr = new int[6][];
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
//            string[] arr_temp = Console.ReadLine().Split(' ');
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
        
        Console.WriteLine(max);
        Console.ReadLine();
    }

    [TestMethod]
    static void Test1()
    {

    } 
}
