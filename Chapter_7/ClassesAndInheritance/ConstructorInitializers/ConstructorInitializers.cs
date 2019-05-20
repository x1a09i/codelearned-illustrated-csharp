using System;

namespace ConstructorExcutionOrder
{
    class BaseClass
    {
        public void Print()
        {
            Console.WriteLine("Virtual Print Called");
        }
        public BaseClass()
        {
            Print();
        }
    }

    class DerivedClass : BaseClass
    {
        new public void Print()
        {
            Console.WriteLine("Override Print Called");
        }
    }

    class ConstructorExcutionOrder
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            // 注意此处会先执行一次基类构造函数
            dc.Print();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
