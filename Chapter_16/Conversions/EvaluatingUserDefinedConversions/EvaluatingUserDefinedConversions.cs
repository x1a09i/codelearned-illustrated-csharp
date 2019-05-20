using System;

namespace EvaluatingUserDefinedConversions
{
    class Person
    {
        public string Name;
        public int Age;

        public static implicit operator int(Person p)
        {
            return p.Age;
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class EvaluatingUserDefinedConversions
    {
        static void Main(string[] args)
        {
            Employee bill = new Employee("Gates", 46);

            // 一句简单的转换，包含了三个步骤
            // 1.Employee类型 → Person类型(预备标准转换)
            // 2.Person类型 → int类型(用户自定义转换)
            // 3.int类型 → float类型(后续标准转换)
            float fAge = bill;

            Console.WriteLine("Person Info: {0}, {1}", bill.Name, fAge);

            Console.ReadKey();
        }
    }
}
