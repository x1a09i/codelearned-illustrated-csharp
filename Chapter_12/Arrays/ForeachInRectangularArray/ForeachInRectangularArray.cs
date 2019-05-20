using System;

namespace ForeachInRectangularArray
{
    class ForeachInRectangularArray
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[,] arr1 = { 
                { 10, 11 }, 
                { 12, 13 }
            };

            foreach (var element in arr1)
            {
                total += element;
                // 注意迭代的顺序：从低纬度到高维度，从左往右
                Console.WriteLine
                ("Element: {0}, Current Total: {1}", element, total);
            }

            Console.ReadKey();
        }
    }
}
