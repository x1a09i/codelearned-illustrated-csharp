using System;

namespace DelegatesWithReturnValues
{
    delegate int MyDelegate();

    class MyClass
    {
        int IntValue = 5;
        public int Add2() { IntValue += 2; return IntValue; }
        public int Add3() { IntValue += 3; return IntValue; }
    }

    class DelegatesWithReturnValues
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            MyDelegate mDel = mc.Add2;
            mDel += mc.Add3;
            mDel += mc.Add2;

            Console.WriteLine("Value: {0}", mDel());

            Console.ReadKey();
        }
    }
}
