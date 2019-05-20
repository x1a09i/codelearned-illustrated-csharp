using System;


namespace ExplicitInterfaceMemberImplementations
{
    interface IIfc1 { void PrintOut(string msg1); }
    interface IIfc2 { void PrintOut(string msg2); }

    class MyClass : IIfc1, IIfc2
    {
        // 显示接口成员实现
        // ※注意，通过这种实现手法定义出来的方法，将不能被类的实例访问
        void IIfc1.PrintOut(string msg1)
        {
            Console.WriteLine("IIfc1: {0}", msg1);
        }

        void IIfc2.PrintOut(string msg2)
        {
            Console.WriteLine("IIfc2: {0}", msg2);
        }

        // 由于上面两个方法已经实现了接口，这个方法将独立存在
        public void PrintOut(string msg)
        {
            Console.WriteLine("Self: {0}", msg);
        }
    }

    class ExplicitInterfaceMemberImplementations
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            IIfc1 ifc1 = (IIfc1)mc;
            ifc1.PrintOut("interface 1");

            IIfc2 ifc2 = (IIfc2)mc;
            ifc2.PrintOut("interface 2");

            mc.PrintOut("Own Method");

            Console.ReadLine();
        }
    }
}
