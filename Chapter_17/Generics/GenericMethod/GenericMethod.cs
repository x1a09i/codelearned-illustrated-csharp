using System;

namespace GenericMethod
{
    class Simple
    {
        // 因为方法是成员，所以泛型方法可以存在于非泛型的类型之中
        public static void ReverseAndPrint<Type>(Type[] arr)
        {
            Array.Reverse(arr);
            foreach(var item in arr)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine();
        }
    }
    class GenericMethod
    {
        static void Main(string[] args)
        {
            var arrInt = new int[] { 1, 2, 3 };
            var arrStr = new string[] { "first", "second", "third" };
            var arrDbl = new double[] { 3.567, 7.891, 2.345 };

            // 每个数组进行两次反转输出操作。第一次直接调用，第二次使用类型推断
            Simple.ReverseAndPrint<int>(arrInt);
            Simple.ReverseAndPrint(arrInt);

            Simple.ReverseAndPrint<string>(arrStr);
            Simple.ReverseAndPrint(arrStr);

            Simple.ReverseAndPrint<double>(arrDbl);
            Simple.ReverseAndPrint(arrDbl);

            Console.ReadKey();
        }
    }
}
