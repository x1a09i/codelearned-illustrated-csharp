using System;

namespace BaseAccess
{
    class BaseClass
    {
        public string fieldBase = "This is base field";
    }

    class DerivedClass : BaseClass
    {
        // 此处用关键字new屏蔽了基类的成员
        new public string fieldBase = "This is derived field";

        public void PrintField()
        {
            Console.WriteLine(fieldBase);
            // 留意此处使用base关键字，明确指定了对基类成员的访问
            Console.WriteLine(base.fieldBase);
        }
    }
    class BaseAccess
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.PrintField();

            Console.ReadKey();
        }
    }
}
