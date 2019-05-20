using System;

namespace GenericDelegates1
{
    delegate void MyDelegate<T>(T value);

    class Simple
    {
        static public void GetStrings(string str)
        {
            Console.WriteLine(str);
        }
        static public void GetUpperStrings(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        static public void GetSqureInt(int val)
        {
            Console.WriteLine((int)Math.Pow(val, 2));
        }
    }

    class GenericDelegates1
    {
        static void Main(string[] args)
        {
            var mdStr = new MyDelegate<string>(Simple.GetStrings);
            mdStr += Simple.GetUpperStrings;

            var mdInt = new MyDelegate<int>(Simple.GetSqureInt);

            mdStr("Hi There!");
            mdInt(30);

            Console.ReadKey();
        }
    }
}
