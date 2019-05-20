using System;

namespace JaggedArrays
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            // 一个二维交错数组
            var Arr = new int[3][,];
            // 分别定义子数组
            Arr[0] = new int[,] {
                { 10, 20 },
                { 100, 200 }
            };

            Arr[1] = new int[,] {
                { 30, 40, 50 },
                { 300, 400, 500 }
            };

            Arr[2] = new int[,] {
                { 60, 70, 80, 90 },
                { 600, 700, 800, 900 }
            };

            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr[i].GetLength(0); j++)
                {
                    // 最内层循环的GetLength()方法一定要使用第二维度——也就是元素的数量，否则输出将不完整
                    for (int k = 0; k < Arr[i].GetLength(1); k++)
                    {
                        Console.WriteLine("Jagged[{0}] Rectangular[{1},{2}] = {3}", i, j, k, Arr[i][j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
