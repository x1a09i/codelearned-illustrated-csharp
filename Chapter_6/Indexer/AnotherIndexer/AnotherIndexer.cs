using System;

namespace AnotherIndexer
{
    class Class1
    {
        int temp0;
        int temp1;

        public int this[int index]
        {
            set
            {
                if (0 == index) 
                    temp0 = value;
                else
                    temp1 = value;
            }
            get
            {
                return (0 == index)
                    ? temp0
                    : temp1;
            }
        }
    }
    class AnotherIndexer
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();

            Console.WriteLine("Values -- T0: {0}, T1: {1}", c1[0], c1[999]);

            c1[0] = 15;
            c1[1] = 20;

            Console.WriteLine("Values -- T0: {0}, T1: {1}", c1[0], c1[999]);

            Console.ReadKey();
        }
    }
}
