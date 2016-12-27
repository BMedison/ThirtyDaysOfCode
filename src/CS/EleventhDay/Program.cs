using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Hourglass
{
    private int[,] _matrix = new int[3, 3];

    public Hourglass()
    {
    }

    public Hourglass(int[,] matrix)
    {
        _matrix = matrix;
    }

    public void SetMatrix(int[,] matrix)
    {
        _matrix = matrix;
    }

    public int Calculate()
    {
        return _matrix[0, 0] + _matrix[0, 1] + _matrix[0, 2] + _matrix[1, 1] + _matrix[2, 0] + _matrix[2, 1] + _matrix[2, 2];
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
        int[][] arr = new int[6][];
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        }

        List<Hourglass> hgs = new List<Hourglass>();
        Hourglass hg1 = new Hourglass(new int[3, 3] { { 1, 1, 1 }, { 0, 1, 0 }, { 1, 1, 1 } });
        Hourglass hg2 = new Hourglass(new int[3, 3] { { 1, 1, 0 }, { 0, 0, 0 }, { 1, 1, 0 } });
        Hourglass hg3 = new Hourglass(new int[3, 3] { { 1, 0, 0 }, { 0, 0, 0 }, { 1, 0, 0 } });
        Hourglass hg4 = new Hourglass(new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } });
        Hourglass hg5 = new Hourglass(new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 2, 4 } });
        Hourglass hg6 = new Hourglass(new int[3, 3] { { 2, 4, 4 }, { 0, 2, 0 }, { 1, 2, 4 } });
        hgs.Add(hg1);
        hgs.Add(hg2);
        hgs.Add(hg3);
        hgs.Add(hg4);
        hgs.Add(hg5);
        hgs.Add(hg6);

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
