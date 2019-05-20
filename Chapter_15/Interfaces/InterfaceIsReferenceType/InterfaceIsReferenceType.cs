using System;

namespace InterfaceIsReferenceType
{
    interface IIfc1
    {
        void PrintOut(string msg);
    }

    class MyClass : IIfc1
    {
        // 注意此处，实现方法的访问修饰符必须是public
        public void PrintOut(string msg)
        {
            Console.WriteLine("Calling through: {0}", msg);
        }
    }

    class InterfaceIsReferenceType
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            mc.PrintOut("Class");
            // 将类的引用转换为接口的引用(强制转换符可省)
            IIfc1 ifc1 = (IIfc1)mc;
            ifc1.PrintOut("Interface");

            Console.ReadKey();
        }
    }
}
