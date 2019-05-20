using System;

namespace Covariance
{
    class Animal
    { public int legs = 4; }

    class Dogs : Animal { }

    // 注意此处使用了out关键字来激活委托之间的协变特性
    delegate T Factory<out T>();

    class Covariance
    {
        static Dogs MakeDog()
        {
            return new Dogs();
        }
        static void Main(string[] args)
        {
            var dogMaker = new Factory<Dogs>(MakeDog);
            // 如果你企图直接将类型参数为派生类的委托赋值给类型参数为基类的委托，这种转换将无法成立
            // 也就是说，赋值兼容性不适用于这种情况，因为即便两个委托的类型参数存在继承关系，但委托本身是平级的 
            Factory<Animal> animalMaker = dogMaker; // ← 如果没有out关键字，此句会产生编译错误

            Console.WriteLine("Dog has {0} legs", animalMaker().legs);

            Console.ReadKey();
        }
    }
}
