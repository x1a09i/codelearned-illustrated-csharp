using System;

namespace ConstructorInitializer
{
    class MyClass
    {
        readonly int firstVar;
        readonly double secondVar;

        public string usrNm;
        public int usrId;

        // 公共构造函数：并不独立存在，而是作为其他构造函数的辅助。因此修饰符设置为Private
        private MyClass()
        {
            firstVar = 20;
            secondVar = 30.5;
        }

        public MyClass(string usrNm) : this()
        {
            this.usrNm = usrNm;
            usrId = -1;
        }

        public MyClass(int usrId) : this()
        {
            usrNm = "Anonymous";
            this.usrId = usrId;
        }

        public void PrintFields()
        {
            Console.WriteLine("ReadOnly fields's Values are {0}, {1}", firstVar, secondVar);
            Console.WriteLine("Public fields's Values are {0}, {1}", usrNm, usrId);
        }
    }
    class ConstructorInitializer
    {
    
        static void Main(string[] args)
        {
            MyClass mcWithId = new MyClass(140019);
            MyClass mcWithNm = new MyClass("xiaoqi.zhang");

            Console.WriteLine("Output of ID initializer is :");
            mcWithId.PrintFields();

            Console.WriteLine();

            Console.WriteLine("Output of NAME initializer is :");
            mcWithNm.PrintFields();

            Console.ReadKey();
        }
    }
}
