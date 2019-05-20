using System;


namespace InheritedMemberAsImplementation
{
    interface IPrintOut
    {
        void PrintOut(string msg);
    }

    class BaseCls
    {
        public void PrintOut(string msg)
        {
            Console.WriteLine("Calling through: {0}", msg);
        }
    }

    // 同时继承基类，并实现接口
    class DerivedCls: BaseCls, IPrintOut
    {
        // Nothing, Just John Snow.
    }

    class InheritedMemberAsImplementation
    {
        static void Main(string[] args)
        {
            DerivedCls dc = new DerivedCls();
            dc.PrintOut("object");

            Console.ReadKey();
        }
    }
}
