using System;

namespace ArrayCovariance
{
    class A
    {
        public string FieldA = "field a";
    }

   class B : A
    {
        public string FieldB = "field b";
    }

    class ArrayCovariance
    {
        static void Main(string[] args)
        {
            A[] aArr = new A[3];
            A[] aArrB = new A[3];

            for (int i = 0; i < aArr.Length; i++)
                aArr[i] = new A();
            // 此处将派生类直接赋值到基类数列中，曰数组协变
            for (int i = 0; i < aArr.Length; i++)
                aArrB[i] = new B();
            // 注意，即使将类B赋值到了数列中，由于数列的基础类仍是A,所以你只能访问类A的字段
            foreach (var item in aArrB)
                Console.WriteLine("Value of ArrayB's field : {0}", item.FieldA);

            Console.ReadKey();
        }
    }
}
