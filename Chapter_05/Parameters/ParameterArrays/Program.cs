using System;

namespace ParameterArrays
{
    class MyClass
    {
        public void ListInts(params int[] inVals)
        {
            if (inVals != null && inVals.Length != 0)
            {
                for (int i = 0; i < inVals.Length; i++)
                {
                    inVals[i] = inVals[i] * 10;
                    Console.WriteLine("{0}", inVals[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 注意，将单个整数作为参数传递，和将数组作为参数传递，结果会不一样
            int first = 5, second = 6, third = 7;
            MyClass mc = new MyClass();
            mc.ListInts(first, second, third);
            Console.WriteLine("{0}, {1}, {2}", first, second, third);

            int[] myArr = new int[] { 5, 6, 7 };
            MyClass mc_arr = new MyClass();
            mc_arr.ListInts(myArr);

            foreach (int x in myArr)
                Console.WriteLine("{0}", x);

            Console.ReadLine();
        }
    }
}
