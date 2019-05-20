using System;

namespace ExtensionMethodsWithGenericClasses
{
    static class ExtendHolder
    {
        // 要在泛型类基础上扩展方法，方法本身也须是泛型的
        public static void Print<T>(this Holder<T> holder)
        {
            T[] vals = holder.GetValues();
            foreach (var val in vals)
                Console.Write(val + ", ");
            Console.WriteLine();
        }
    }

    class Holder<T>
    {
        T[] vals = new T[3];
        public Holder(T v1, T v2, T v3)
        {
            vals[0] = v1; vals[1] = v2; vals[2] = v3;
        }
        public T[] GetValues() { return vals; }
    }

    class ExtensionMethodsWithGenericClasses
    {
        static void Main(string[] args)
        {
            var hInt = new Holder<int>(1, 2, 3);
            var hStr = new Holder<string>("a1", "b2", "c3");

            hInt.Print();
            hStr.Print();

            Console.ReadKey();
        }
    }
}
