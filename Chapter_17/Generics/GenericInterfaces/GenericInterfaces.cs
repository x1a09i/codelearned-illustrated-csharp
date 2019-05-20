using System;

namespace GenericInterfaces
{
    interface IMyIfc<T>
    {
       T ReturnIt(T value);
    }

    // 从同一个泛型接口产生不同类型的构造类型接口，并将它们独立使用
    class Simple : IMyIfc<int>, IMyIfc<string>
    {
        public int ReturnIt (int value)
        {
            return value;
        }

        public string ReturnIt(string value)
        {
            return value;
        }
    }

    class GenericInterfaces
    {
        static void Main(string[] args)
        {
            var simple = new Simple();

            Console.WriteLine("{0}", simple.ReturnIt(5));
            Console.WriteLine("{0}", simple.ReturnIt("Hi there."));
        }
    }
}
