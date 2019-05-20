using System;

namespace ExpressionsAndOperators
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
                if (value < MIN_VALUE)
                    _limitedIntVal = MIN_VALUE;
                else
                    _limitedIntVal = value > MAX_VALUE
                                   ? MAX_VALUE
                                   : value;
            }
        }
        //若要定义显式转换，需将关键字implicit变更为explicit
        public static implicit operator int(LimitedInt li)
        {
            return li.LimitedIntVal;
        }

        //若要定义显式转换，需将关键字implicit变更为explicit
        public static implicit operator LimitedInt(int val)
        {
            LimitedInt li = new LimitedInt();
            li.LimitedIntVal = val;
            return li;
        }
    }

    class UserDefinedTypeConversions
    {
        static void Main(string[] args)
        {
            // 注意此处已经执行了隐式转换
            LimitedInt li = 500;
            int value = li;

            Console.WriteLine("li: {0}, value: {1}", li.LimitedIntVal, value);

            Console.ReadKey();
        }
    }
}
