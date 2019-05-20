using System;

namespace TheAsOperator
{
    class Person
    {
        public string Name = "Anonymous";
        public int Age = 55;
    }

    class Employee : Person { }

    class TheAsOperator
    {
        static void Main(string[] args)
        {
            Employee bill = new Employee();
            Person p = new Person();

            // 使用as运算符代替强制转换符来避免InvalidCastException异常的发生
            p = bill as Person;

            if (null != p)
            {
                Console.WriteLine("Person Info: {0}, {1}", p.Name, p.Age);
            }
        }
    }
}
