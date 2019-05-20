using System;

namespace UsingIComparableInterface
{
    class MyIntClass : IComparable
    {
        public int IntVal { get; set; }
        // 对IComparable的CompareTo进行实现
        public int CompareTo(Object obj)
        {
            // 注意要先将object类型进行强制转换
            MyIntClass mc = (MyIntClass)obj;

            if (IntVal < mc.IntVal) return -1;
            if (IntVal > mc.IntVal) return 1;

            return 0;
        }
    }
    class UsingIComparableInterface
    {
        static void PrintArray(string msg, MyIntClass[] myIntClassArr)
        {
            Console.WriteLine(msg);

            foreach (var item in myIntClassArr)
                Console.Write(item.IntVal + " ");
            Console.WriteLine();     
        }

        static void Main(string[] args)
        {
            var inputIntArr = new int[] { 20, 4, 614, 15, 3977, 77, 13 };
            var myIntClassArr = new MyIntClass[inputIntArr.Length];

            for (int i = 0; i < inputIntArr.Length; i++)
            {
                myIntClassArr[i] = new MyIntClass();
                myIntClassArr[i].IntVal = inputIntArr[i];
            }

            PrintArray("Initial Order: ", myIntClassArr);

            Array.Sort(myIntClassArr);
            PrintArray("Sorted Order: ", myIntClassArr);

            Console.ReadKey();
        }
    }
}
