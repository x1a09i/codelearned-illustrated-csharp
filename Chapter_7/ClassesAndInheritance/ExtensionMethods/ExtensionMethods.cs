using System;

namespace ExtensionMethods
{
    sealed class MyData
    {
        private double _d1, _d2, _d3;
        public MyData(double D1, double D2, double D3)
        {
            _d1 = D1; _d2 = D2; _d3 = D3;
        }
        public double Sum()
        {
            return _d1 + _d2 + _d3;
        }
    }

    // 在MyData类的基础上，对其进行扩展
    static class ExtendMyData
    {
        // 留意this关键字的使用，其为定义扩展方法的关键
        public static double Avg(this MyData md)
        {
            return md.Sum() / 3;
        }
    }

    class ExtensionMethods
    {
        static void Main(string[] args)
        {
            MyData md = new MyData(3.0, 4.0, 5.0);
            Console.WriteLine("Sum Of MyData is {0}", md.Sum());
            // 此处对Avg()方法优雅的使用！
            Console.WriteLine("Average Of MyData is {0}", md.Avg());

            Console.ReadKey();
        }
    }
}
