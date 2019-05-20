using System;

namespace OverrideAgain
{
    class MyBaseClass
    {
        virtual public void Print()
        { Console.WriteLine("This is the base class."); }
    }

    class MyDerivedClass : MyBaseClass
    {
        override public void Print()
        { Console.WriteLine("This is the derived class."); }
    }

    class SecondDerivedClass : MyDerivedClass
    {
        override public void Print()
        { Console.WriteLine("This is the 2nd derived class."); }
    }

    // 最高派生类（Most-derived） class
    class MostDerivedClass : SecondDerivedClass
    {
        override public void Print()
        { Console.WriteLine("This is the most-derived class."); }

    }
    class OverrideAgain
    {
        static void Main(string[] args)
        {
            MostDerivedClass mostdc = new MostDerivedClass();
            MyBaseClass mbc = (MyBaseClass)mostdc;
            mbc.Print();

            Console.ReadKey();
        }
    }
}
