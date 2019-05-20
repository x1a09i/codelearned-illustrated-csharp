using System;

namespace GenericDelegates2
{
    delegate TR Func<T1, T2, TR>(T1 va1, T2 var2);

    class Simple
    {
        static public string PrintAddResult(int x, int y)
        {
            return (x + y).ToString();
        }
    }

    class GenericDelegates2
    {
        static void Main(string[] args)
        {
            var funcAdd = new Func<int, int, string>(Simple.PrintAddResult);
            Console.WriteLine("Total result is: {0}", funcAdd(15, 30));

            Console.ReadKey();
        }
    }
}
