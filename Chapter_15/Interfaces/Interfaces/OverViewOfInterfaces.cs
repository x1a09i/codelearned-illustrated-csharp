using System;

namespace Interfaces
{
    interface IGetInfo
    {
        string GetName();
        string GetAge();
    }

    class CA : IGetInfo
    {
        public string name;
        public int age;
        // 对接口部分的实现
        public string GetName()
        {
            return name;
        }
        public string GetAge()
        {
            return age.ToString();
        }
    }

    class CB : IGetInfo
    {
        public string firstName;
        public string lastName;
        public double personalAge;
        // 对接口部分的实现
        public string GetName()
        {
            return firstName + " " + lastName;
        }
        public string GetAge()
        {
            return personalAge.ToString();
        }
    }

    class OverViewOfInterfaces
    {
        static void PrintInfo(IGetInfo item)
        {
            Console.WriteLine("Name:{0}, Age{1}", item.GetName(), item.GetAge());
        }

        static void Main(string[] args)
        {
            CA a = new CA { name = "Bill Gates", age = 36 };
            CB b = new CB { firstName = "Bill", lastName = "Gates", personalAge = 36.0 };

            // 对象的引用会自动转换（CAST）成对接口的引用
            PrintInfo(a);
            PrintInfo(b);

            Console.ReadKey();
        }
    }
}
