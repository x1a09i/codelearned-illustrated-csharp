using System;

namespace StackExampleUsingGenerics
{
    class MyStack<Type>
    {
        Type[] StackArray;
        int Pointer = 0;
        int Length;

        public bool IsStackFull { get { return Pointer == Length; } }
        public bool IsStackEmpty { get { return Pointer == 0; } }

        // 注意，声明构造函数时没有用到类型参数
        public MyStack(int maxLength)
        {
            Length = maxLength;
            StackArray = new Type[maxLength];
        }

        public void Push(Type val)
        {
            // 此处的递增运算符一定要用后置
            if (!IsStackFull)
                StackArray[Pointer++] = val;
        }

        public Type Pop()
        {
            return (!IsStackEmpty)
                // 此处的递减运算符一定要用前置
                ? StackArray[--Pointer]
                : StackArray[0];
        }

        public void Print()
        {
            for (int i = Pointer - 1; i >= 0; i--)
                Console.WriteLine(" Value: {0}", StackArray[i]);
        }

        public void PrintAllStuff()
        {
            foreach(var value in StackArray)
                Console.WriteLine(" Value: {0}", value);
        }
    }
    class StackExampleUsingGenerics
    {
        static void Main(string[] args)
        {
            MyStack<int> myIntStack = new MyStack<int>(10);
            MyStack<string> myStrStack = new MyStack<String>(5);

            myIntStack.Push(3);
            myIntStack.Push(5);
            myIntStack.Pop();
            myIntStack.Pop();
            myIntStack.Pop();

            myStrStack.Push("This is fun");
            myStrStack.Push("Hi there! ");
            myStrStack.Push("Let's Party! ");
            myStrStack.Pop();

            Console.WriteLine("*******All Stuff*******");
            myIntStack.PrintAllStuff();
            myStrStack.PrintAllStuff();

            Console.WriteLine("*******Valued Stuff*******");
            myIntStack.Print();
            myStrStack.Print();

            Console.ReadKey();
        }
    }
}
