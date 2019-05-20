using System;

namespace RefBaseClassByCastDerivedClass
{
    class MyBaseClass
    {
        public void Print()
        {
            Console.WriteLine("This is Base Class's Print Method");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        new public void Print()
        {
            Console.WriteLine("This is Derived Class's Print Method");
        }
    }

    class RefBaseClassByCastDerivedClass
    {
        static void Main(string[] args)
        {
            MyDerivedClass mdc = new MyDerivedClass();
            // 将对派生类的引用，显示转换为对基类的引用（转换符可以省略）
            MyBaseClass mbc = (MyBaseClass)mdc;

            mdc.Print();
            mbc.Print();

            Console.ReadKey();
        }
    }
}
