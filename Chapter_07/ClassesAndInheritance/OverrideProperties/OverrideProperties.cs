using System;

namespace OverrideProperties
{
    class BaseClass
    {
        public virtual int MyInt { get; set; }
    }

    // 对属性进行覆盖操作
    class DerivedClass : BaseClass
    {
        private int _myInt = 5;
        public override int MyInt
        {
            get
            {
                return _myInt;
            }
        }
    }

    class OverrideProperties
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            BaseClass bc = (BaseClass)dc;

            bc.MyInt = 100;

            Console.WriteLine(bc.MyInt);
            Console.ReadKey();
        }
    }
}
