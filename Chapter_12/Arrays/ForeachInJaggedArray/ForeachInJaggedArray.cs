using System;

namespace ForeachInJaggedArray
{
    class ForeachInJaggedArray
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[][] arr1 = new int[2][];

            arr1[0] = new int[] { 10, 11 };
            arr1[1] = new int[] { 12, 13, 14 };

            foreach(var arr in arr1)
            {
                Console.WriteLine("Starting new array");
                foreach(var item in arr)
                {
                    sum += item;
                    Console.WriteLine(" Item: {0}, Current Total: {1}", item, sum);
                }
            }

            Console.ReadKey();
        }
    }
}
