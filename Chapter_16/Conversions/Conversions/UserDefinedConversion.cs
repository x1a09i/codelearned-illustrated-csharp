using System;

namespace Conversions
{
    class Person
    {
        public string name;
        // 年龄保密～
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        // 通过自定义将Person隐式转换为int来获取年龄
        public static implicit operator int(Person p)
        {
            return p.age;
        }
        // 通过自定义将int隐式转换为person来获取一位无名有龄氏
        public static implicit operator Person(int i)
        {
            return new Person("A man", i);
        }
    }
    class UserDefinedConversion
    {
        static void Main(string[] args)
        {
            Person p = new Person("bill gates", 36);
            int age = p;
            Console.WriteLine("{0} is {1} years old.", p.name, age);

            p = 99;
            age = p;
            Console.WriteLine("{0} is {1} years old.", p.name, age);

            Console.ReadKey();
        }
    }
}
