using System;


namespace UsefulMembersOfArray
{
    class UsefulMembersOfArray
    {
        public static void PrintIntArray(int[] a)
        {
            foreach (var x in a)
                Console.Write("{0} ", x);
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 15, 20, 5, 25, 10 };
            PrintIntArray(arr);
            // 排序
            Array.Sort(arr);
            PrintIntArray(arr);
            // 反转
            Array.Reverse(arr);
            PrintIntArray(arr);

            Console.WriteLine();
            // 获取维度数、数组元素总数
            Console.WriteLine("Rank = {0}, Length = {1}", arr.Rank, arr.Length);
            // 获取特定维度的数组元素数量
            Console.WriteLine("GetLength(0) = {0}", arr.GetLength(0));
            Console.WriteLine("GetType() = {0}", arr.GetType());
        }
    }
}
