using System;

namespace OutputParameters
{
    class MyClass { public int val = 20; }
    class OutputParameters
    {
        static void Main(string[] args)
        {
            // 为输出型参数的实参赋值时没有任何意义的，但你可以这么做，自己开心坠吼:P
            MyClass a1 = new MyClass();
            int a2 = 10;
            MyMethod(out a1, out a2);

            Console.WriteLine("Output Value Details:");
            Console.WriteLine("a1.val:{0,2:n}  a2:{1,2:n}", a1.val, a2);
            Console.ReadLine();
        }

        static void MyMethod(out MyClass f1, out int f2) {
            // 切记，所有的形参在方法结束之前必须全部被赋值
            f1 = new MyClass();
            f1.val = 25;
            f2 = 5;
        }
    }
}
