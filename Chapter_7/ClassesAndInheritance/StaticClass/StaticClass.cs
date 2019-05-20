using System;

namespace StaticClass
{
    static public class MyMathLibrary
    {
        public static float PI = 3.1415926535f;
        // 判断是否为奇数的静态方法
        public static bool IsOdd(int val)
        {
            return (val % 2 == 1);
        }
        // 计算整数的倍数
        public static int DoubleInt(int val)
        {
            return val * 2;
        }
    }
    class StaticClass
    {
        static void Main(string[] args)
        {
            int val = 3;
            // 静态类无需实例化
            Console.WriteLine("{0} is odd : {1}", val, MyMathLibrary.IsOdd(val));
            Console.WriteLine("The double value of {0} is {1}", val, MyMathLibrary.DoubleInt(val));
            Console.WriteLine("What about a Pie ? {0}", MyMathLibrary.PI);

            Console.ReadKey();
        }
    }
}
