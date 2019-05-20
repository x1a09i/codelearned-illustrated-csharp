using System;

namespace VirtualAndOverrideMethods
{
    class MyBaseClass
    {
        // virtual关键字
        virtual public void Print()
        {
            Console.WriteLine("This is Base Class's Print Method");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        // override关键字
        override public void Print()
        {
            Console.WriteLine("This is Derived Class's Print Method");
        }
    }

    class VirtualAndOverrideMethods
    {
        static void Main(string[] args)
        {
            MyDerivedClass mdc = new MyDerivedClass();
            MyBaseClass mbc = (MyBaseClass)mdc;

            mdc.Print();
            // 即便是从基类进行方法调用，所被调用的仍然会是派生类中的方法
            mbc.Print();

            Console.ReadKey();
        }
    }
}
