using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
    partial class MyClass
    {
        // 分部方法：定义声明部分
        partial void PrintSum(int x, int y);
        public void Add(int x, int y)
        {
            PrintSum(x, y);
        }
    }

    partial class MyClass
    {
        // 分部方法：实现声明部分
        partial void PrintSum(int x, int y)
        {
            Console.WriteLine("Sum is {0}", x + y);
        }
    }

    class PartialMethods
    {
        static void Main(string[] args)
        {
            var mc = new MyClass();
            mc.Add(5, 6);

            Console.ReadKey();
        }

    }
}
