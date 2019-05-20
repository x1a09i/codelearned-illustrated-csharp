using System;

namespace DelegateExample
{
    delegate void PrintFunc();

    class PrintTest
    {
        public void Print1()
        {
            Console.WriteLine("Print1 -- instance");
        }

        public static void Print2()
        {
            Console.WriteLine("Print2 -- static");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrintTest test = new PrintTest();

            PrintFunc pf = test.Print1;
            pf += PrintTest.Print2;
            pf += test.Print1;
            pf += PrintTest.Print2;

            if (null != pf)
                pf();
            else
                Console.WriteLine("Delegate is empty");

            Console.ReadKey();
        }
    }
}
