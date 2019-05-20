using System;

namespace AbstractClassAndMethod
{
    abstract class MyBase
    {
        public int sideLength = 10;
        public int triangleSideCount = 3;

        abstract public void PrintStuff(string str);
        abstract public int MyInt { get; set; }

        public int CalcPerimeterLength()
        {
            return sideLength * triangleSideCount;
        }
    }

    class MyClass : MyBase
    {
        public override void PrintStuff(string str)
        {
            Console.WriteLine(str);
        }

        private int _myInt;

        public override int MyInt
        {
            get
            {
                return _myInt;
            }
            set
            {
                _myInt = value;
            }
        }
    }

    class AbstractClassAndMethod
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            mc.PrintStuff("Here is some text");

            mc.MyInt = 28;
            Console.WriteLine(mc.MyInt);

            Console.WriteLine("Perimeter Length: {0}", mc.CalcPerimeterLength());

            Console.ReadKey();
        }
    }
}
