using System;
using System.Collections;

namespace IEnumeratorInterface
{
    class IEnumeratorInterface
    {
        static void Main(string[] args)
        {
            int[] myArray = { 0, 1, 2, 3, 4 };
            // 此处需要添加对System.Collections的引用才能使用IEnumerator接口
            IEnumerator ie = myArray.GetEnumerator();
            // 以下的代码算是为foreach语句重新造了一次轮子
            // 如果你用的是foreach语句，那么在CIL中你会发现，编译器生成的代码跟下面的内容大致雷同
            while (ie.MoveNext())
            {
                // 因为Current属性返回的是一个object类型，所以你可以选择做一次拆箱处理
                Console.WriteLine((int)ie.Current);
            }

            Console.ReadKey();
        }
    }
}
