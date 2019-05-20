using System;

namespace Contravariance
{
    class Animal { public int NumberOfLegs = 4; }
    class Dog : Animal { }

    // 注意此处使用了in关键字来激活委托之间的逆变特性
    delegate void Action1<in T>(T obj);

    class Contravariance
    {
        static void ActOnAnimal(Animal a)
        { Console.WriteLine(a.NumberOfLegs); }

        static void Main(string[] args)
        {
            var actAnimal = new Action1<Animal>(ActOnAnimal);
            // 此处的情况跟协变相反：企图将从基类类型参数构造的类，赋值到从派生类类型参数构造的类
            Action1<Dog> actDog = actAnimal; // ← 如果没有in关键字，此句会产生编译错误

            actDog(new Dog());

            Console.ReadKey();
        }
    }
}
