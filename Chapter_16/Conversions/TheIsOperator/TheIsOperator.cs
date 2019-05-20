using System;

namespace TheIsOperator
{
    class Person
    {
        public string Name = "Anonymous";
        public int Age = 25;
    }

    class Employee : Person { }

    class TheIsOperator
    {
        static void Main(string[] args)
        {
            Employee bill = new Employee();
            Person p;
            // 用is运算符来验证两个引用之间能否成功转换——你有没有人性啊？
            if (bill is Person)
            {
                p = bill;
                Console.WriteLine("Person Info: {0}, {1}", p.Name, p.Age);
            }
        }
    }
}
