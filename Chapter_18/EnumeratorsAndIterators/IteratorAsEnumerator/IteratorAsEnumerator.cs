using System;
using System.Collections.Generic;

namespace IteratorAsEnumerator
{
    class MyClass
    {
        // 此处的方法名一定要为GetEnumerator()
        public IEnumerator<string> GetEnumerator()
        {
            return BlackAndWhite();
        }

        public IEnumerator<string> BlackAndWhite()
        {
            yield return "white";
            yield return "gray";
            yield return "black";
        }
    }
    class IteratorAsEnumerator
    {
        static void Main(string[] args)
        {
            var mc = new MyClass();
            foreach (var item in mc)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
