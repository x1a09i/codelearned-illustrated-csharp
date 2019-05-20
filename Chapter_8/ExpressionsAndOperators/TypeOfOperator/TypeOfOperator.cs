using System;
// 留意此处对反射命名空间的引用，它可以提供更全面的类型信息
using System.Reflection;

namespace TypeOfOperator
{
    class SomeAwesomeClass
    {
        public int Field1;
        public int Field2;

        public void Method1() { }
        public int Method2() { return 1; }
    }
    class TypeOfOperator
    {
        static void Main(string[] args)
        {
            Type t = typeof(SomeAwesomeClass);
            // 下面的两个类型来自System.Reflection命名空间
            FieldInfo[] fi = t.GetFields();
            MethodInfo[] mi = t.GetMethods();

            Console.WriteLine("Made by typeOf operator:");

            foreach (FieldInfo f in fi)
                Console.WriteLine("Field:{0}", f.Name);
            foreach (MethodInfo m in mi)
                Console.WriteLine("Method:{0}", m.Name);

            // 利用类的对象的GetType方法达到同样的效果
            Console.WriteLine("Made by GetType Method:");

            SomeAwesomeClass sc = new SomeAwesomeClass();
            t = sc.GetType();

            fi = t.GetFields();
            mi = t.GetMethods();

            foreach (FieldInfo f in fi)
                Console.WriteLine("Field:{0}", f.Name);
            foreach (MethodInfo m in mi)
                Console.WriteLine("Method:{0}", m.Name);

            Console.ReadKey();
        }
    }
}
