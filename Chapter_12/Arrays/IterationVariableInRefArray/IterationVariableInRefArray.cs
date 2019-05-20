using System;

namespace IterationVariableInRefArray
{
    class MyClass
    {
        public int MyField = 0;
    }
    class IterationVariableInRefArray
    {
        static void Main(string[] args)
        {
            MyClass[] mcArr = new MyClass[4];

            // 为类的数组赋上初值
            for(int i = 0; i < mcArr.Length; i++)
            {
                mcArr[i] = new MyClass();
                mcArr[i].MyField = i;
            }

            // 用foreach中的迭代变量将所有类的字段+10
            foreach(var item in mcArr)
            {
                item.MyField += 10;
                Console.WriteLine("{0}", item.MyField);
            }

            Console.ReadKey();
        }
    }
}
