using System;
using System.Collections.Generic;

namespace IteratorAsEnumerable
{
    class MyClass
    {
        public IEnumerator<string> GetEnumerator()
        {
            // 其实这块代码是没有必要写的（如果你不想让这个类本身也成为一个可枚举类的话）
            return BlackAndWhite().GetEnumerator();
        }

        public IEnumerable<string> BlackAndWhite()
        {
            yield return "white";
            yield return "gray";
            yield return "black";
        }
    }
    class IteratorAsEnumerable
    {
        static void Main(string[] args)
        {
            var mc = new MyClass();
            foreach (var item in mc)
                Console.WriteLine(item);

            Console.WriteLine();

            foreach(var item in mc.BlackAndWhite())
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
