using System;

namespace OperatorOverloading
{
    class LimitedInt
    {
        const int MIN_VALUE = 0;
        const int MAX_VALUE = 100;

        private int _limitedIntVal;
        public int LimitedIntVal
        {
            get
            {
                return _limitedIntVal;
            }
            set
            {
                if (value > MAX_VALUE)
                    _limitedIntVal = MAX_VALUE;
                else
                    _limitedIntVal = value < MIN_VALUE
                                   ? MIN_VALUE
                                   : value;
            }
        }

        // 重载一元负运算符
        public static LimitedInt operator -(LimitedInt li)
        {
            // 负数直接变为0
            li.LimitedIntVal = -li.LimitedIntVal;
            return li;
        }

        // 重载减法运算符
        public static LimitedInt operator -(LimitedInt x, LimitedInt y)
        {
            LimitedInt li = new LimitedInt();
            li.LimitedIntVal = x.LimitedIntVal - y.LimitedIntVal;
            return li;
        }

        // 重载加法运算符
        public static LimitedInt operator +(LimitedInt x, double y)
        {
            LimitedInt li = new LimitedInt();
            li.LimitedIntVal = x.LimitedIntVal + (int)y;
            return li;
        }
    }
    class OperatorOverloading
    {
        static void Main(string[] args)
        {
            LimitedInt li1 = new LimitedInt();
            LimitedInt li2 = new LimitedInt();
            LimitedInt li3 = new LimitedInt();
            double addVal = 256.0;

            li1.LimitedIntVal = 10; li2.LimitedIntVal = 26;
            Console.WriteLine(" li1: {0}, li2: {1}", li1.LimitedIntVal, li2.LimitedIntVal);

            li3 = li1 + addVal;
            Console.WriteLine("{0} + {1} = {2}", li1.LimitedIntVal, addVal, li3.LimitedIntVal);

            li3 = -li1;
            Console.WriteLine("-{0} = {1}", li1.LimitedIntVal, li3.LimitedIntVal);

            li3 = li2 - li1;
            Console.WriteLine(" {0} - {1} = {2}",
            li2.LimitedIntVal, li1.LimitedIntVal, li3.LimitedIntVal);

            li3 = li1 - li2;
            Console.WriteLine(" {0} - {1} = {2}",
            li1.LimitedIntVal, li2.LimitedIntVal, li3.LimitedIntVal);

            Console.ReadKey();
        }
    }
}
