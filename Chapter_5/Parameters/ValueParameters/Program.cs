using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndRefParameters
{
    class MyClass { public int val = 20; }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a1 = new MyClass();
            int a2 = 10;
            Console.WriteLine("Value Parameters:");
            MyMethod(a1, a2);
            Console.WriteLine("a1.Val: {0}, a2: {1}", a1.val, a2);

            Console.WriteLine();

            Console.WriteLine("Reference Parameters:");
            MyMethod_Ref(ref a1, ref a2);
            Console.WriteLine("a1.Val: {0}, a2: {1}", a1.val, a2);

            Console.ReadLine();
        }

        static void MyMethod(MyClass f1, int f2) {
            // 值传递，将变量的值从实参复制到实参
            f1.val += 5;
            f2 += 5;
            Console.WriteLine("f1.Val: {0}, f2: {1}", f1.val, f2);
        }

        static void MyMethod_Ref(ref MyClass f1, ref int f2) {
            // 参数传递，相当于给变量起了一个别名（alias）
            f1.val += 5;
            f2 += 5;
            Console.WriteLine("f1.Val: {0}, f2: {1}", f1.val, f2);
        }
    }
}
