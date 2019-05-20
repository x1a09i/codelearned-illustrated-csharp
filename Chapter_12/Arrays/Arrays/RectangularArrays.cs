using System;

namespace Arrays
{
    class RectangularArrays
    {
        static void Main(string[] args)
        {
            // 使用隐式类型来定义矩阵数组
            var arr = new int[,] {
                { 0, 1, 2 }, 
                { 10, 11, 12 }
            };

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    Console.WriteLine("Element [{0},{1}] is {2}", i, j, arr[i, j]);

            Console.ReadKey();
        }
    }
}
