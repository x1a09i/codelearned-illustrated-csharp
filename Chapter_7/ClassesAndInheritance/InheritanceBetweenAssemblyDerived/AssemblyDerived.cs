using System;
// 此处引用基类所属的命名空间
using AssemblyBase;

namespace AssemblyDerived
{
    class DerivedClass : BaseClass { }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.PrintMyself();

            Console.ReadKey();
        }
    }
}
