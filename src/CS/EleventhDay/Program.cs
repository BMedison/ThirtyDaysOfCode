using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class BigMatrix
{
    int[][] _bigMatrix;

    public BigMatrix(int[][] bigMatrix)
    {
        _bigMatrix = bigMatrix;
    }

    public List<int[,]> SeparateMatrix()
    {
        int[,] small_matrix = new int[3,3];
        int x = _bigMatrix.GetLength(0);
        int y = _bigMatrix[0].GetLength(0);
        List<int[,]> sm = new List<int[,]>();
        for(int ix = 0; ix < x - 3; ix++)
        {
            for (int iy = 0; iy < y - 3; iy++)
            {
                small_matrix[0,0] = _bigMatrix[ix + 0][iy + 0];
                small_matrix[0,1] = _bigMatrix[ix + 0][iy + 1];
                small_matrix[0,2] = _bigMatrix[ix + 0][iy + 2];
                small_matrix[1,0] = _bigMatrix[ix + 1][iy + 0];
                small_matrix[1,1] = _bigMatrix[ix + 1][iy + 1];
                small_matrix[1,2] = _bigMatrix[ix + 1][iy + 2];
                small_matrix[2,0] = _bigMatrix[ix + 2][iy + 0];
                small_matrix[2,1] = _bigMatrix[ix + 2][iy + 1];
                small_matrix[2,2] = _bigMatrix[ix + 2][iy + 2];
                sm.Add(small_matrix);
                small_matrix.Initialize();
            }
        }

        return sm;
    }
}

public class Hourglass
{
    private int[,] _matrix = new int[3, 3];

    private Hourglass()
    {
    }

    private void SetMatrix(int[,] matrix)
    {
        _matrix = matrix;
    }

    private int Calculate()
    {
        return _matrix[0, 0] + _matrix[0, 1] + _matrix[0, 2] + _matrix[1, 1] + _matrix[2, 0] + _matrix[2, 1] + _matrix[2, 2];
    }

    public Hourglass(int[,] matrix)
    {
        this.SetMatrix(matrix);
    }

    public int Summa
    {
        get { return this.Calculate(); }
    }
}

class EleventhDay
{
    static void Main(string[] args)
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
//            string[] arr_temp = Console.ReadLine().Split(' ');
            string[] arr_temp = str[arr_i].Split(' ');
            arr[arr_i] = arr_temp.Select(x => Convert.ToInt32(x)).ToArray();
        }

        BigMatrix bm = new BigMatrix(arr);
        List<int[,]> arrs = bm.SeparateMatrix();

        List<Hourglass> hgs = new List<Hourglass>();

        int max = 0;
        foreach(var item in hgs)
        {
            if (item.Summa > max)
                max = item.Summa;

            Console.WriteLine(item.Summa);
        }

        Console.WriteLine(max);
        Console.ReadLine();
    }
}
