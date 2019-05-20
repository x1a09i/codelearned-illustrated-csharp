using System;

namespace MaskingBaseClassMembers
{
    class MaskingBaseClassMembers
    {
        class BaseClass
        {
            public string fieldBase = "Base Field";
            public void MethodBase(string value)
            {
                Console.WriteLine("Base Class Method Output:{0}", value);
            }
        }

        class DerivedClass : BaseClass
        {
            // 注意，此处用new关键字告诉编译器：我把上头的成员给屏蔽了！爱咋咋地！
            new public string fieldBase = "Derived Field";
            new public void MethodBase(string value)
            {
                Console.WriteLine("Derived Class Method Output:{0}", value);
            }
        }
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.MethodBase(dc.fieldBase);

            Console.ReadKey();
        }
    }
}
