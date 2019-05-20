using System;
using System.Linq;

namespace DelegatesAsParameters
{
    class DelegatesAsParameters
    {
        static bool IsOdd(int x) { return x % 2 == 1; }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            
            // 留意此处使用的Func泛型委托——它是LINQ预定义的委托类型
            Func<int, bool> myDel = new Func<int, bool>(IsOdd);
            var oddCount = intArray.Count(myDel);

            Console.WriteLine("{0} odds in array", oddCount);

            // 如果需要关联到委托的方法非常简单（只有一条返回语句），且只使用在这一个地方
            // 那末，祭出Lambda大法的时候到了！
            var evenCount = intArray.Count(x => x % 2 == 0);
            Console.WriteLine("{0} evens in array", evenCount);

            Console.ReadKey();
        }
    }
}
