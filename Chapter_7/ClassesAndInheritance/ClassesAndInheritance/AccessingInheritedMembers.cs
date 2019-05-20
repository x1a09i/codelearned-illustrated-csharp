using System;

namespace AccessingInheritedMembers
{
    // 基类
    class BaseClass
    {
        public string fieldBase = "base class field";
        public void MethodBase(string value)
        {
            Console.WriteLine("Base Class Method Output:{0}", value);
        }
    }

    // 派生类
    class DerivedClass : BaseClass
    {
        public string fieldDerived = "derived class field";
        public void MethodDerived(string value)
        {
            Console.WriteLine("Derived Class Method Output:{0}", value);
        }
    }

    class AccessingInheritedMembers
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.MethodBase(dc.fieldBase);
            dc.MethodBase(dc.fieldDerived);

            dc.MethodDerived(dc.fieldBase);
            dc.MethodDerived(dc.fieldDerived);

            Console.ReadKey();
        }
    }
}
