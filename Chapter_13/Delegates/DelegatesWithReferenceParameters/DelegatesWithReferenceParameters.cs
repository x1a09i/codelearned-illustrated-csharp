using System;

namespace DelegatesWithReferenceParameters
{
    delegate void MyDelegate(ref int x);

    class DelegatesWithReferenceParameters
    {
        public void Add2(ref int x) { x += 2; }
        public void Add3(ref int x) { x += 3; }

        static void Main(string[] args)
        {
            DelegatesWithReferenceParameters mc = new DelegatesWithReferenceParameters();

            MyDelegate mDel = mc.Add2;

            mDel += mc.Add3;
            mDel += mc.Add2;

            int x = 5;
            mDel(ref x);

            Console.WriteLine("Value: {0}", x);

            Console.ReadKey();
        }
    }
}
