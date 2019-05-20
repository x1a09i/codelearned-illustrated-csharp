using System;

namespace RefAsParameter
{
    class MyClass { public int val = 10; }

    class RefAsParameter
    {
        static void RefPara(ref MyClass f1) {
            f1.val = 50;
            Console.WriteLine("After member assignment: {0}.", f1.val);
            /* 
             * 注意：此处的对象创建，会根据传参的方式做出不同的动作
             * 值传递：新建的对象将在方法结束时消失，因此程序的输出为（10, 50, 10, 50）
             * 引用传递：新建的对象将传回给实参，因此程序的输出为（10, 50, 10, 10）
             */
            f1 = new MyClass();
            Console.WriteLine("After new object creation: {0}.", f1.val);
        }

        static void Main(string[] args)
        {
            MyClass a1 = new MyClass();

            Console.WriteLine("Before method call: {0}.", a1.val);
            RefPara(ref a1);
            Console.WriteLine("After method call: {0}.", a1.val);
            Console.ReadLine();
        }
    }
}
