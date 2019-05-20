using System;

namespace Properties
{
    class C1
    {
        // 属性和后备字段的命名公约
        private int _theValue = 10;
        public int TheValue
        {
            get
            {
                return _theValue;
            }
            set
            {
                _theValue = value > 100
                    ? 100
                    : value;
            }
        }
    }

    class C2
    {
        // 属性自动实现
        public int MyProperty { get; set; }
    }

    class Triangle
    {
        // 用属性实现勾股定理（只读属性）
        public double a = 3;
        public double b = 4;

        public double CalcHypotenuse
        {
            get
            {
                return Math.Sqrt(a * a + b * b);
            }
        }
    }
    class Properties
    {
        static void Main(string[] args)
        {
            C1 c = new C1();
            Console.WriteLine(c.TheValue);

            c.TheValue = 200;
            Console.WriteLine(c.TheValue);

            Triangle t1 = new Triangle();
            Console.WriteLine(t1.CalcHypotenuse);

            Console.ReadLine();
        }
    }
}
