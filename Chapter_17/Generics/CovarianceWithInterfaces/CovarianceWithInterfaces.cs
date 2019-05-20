using System;

namespace CovarianceWithInterfaces
{
    class Animal
    { public string Name; }

    class Dogs : Animal
    { }

    interface IMyIfc<out T>
    { T GetFirst(); }

    class SimpleReturn<T> : IMyIfc<T>
    {
        public T[] items = new T[3];
        public T GetFirst()
        {
            return items[0];
        } 
    }

    class CovarianceWithInterfaces 
    {
        static void PrintFirstItemName(IMyIfc<Animal> returner)
        {
            Console.WriteLine(returner.GetFirst().Name);
        }

        static void Main(string[] args)
        {
            var spDogs = new SimpleReturn<Dogs>();
            spDogs.items[0] = new Dogs { Name = "Lascu" };

            IMyIfc<Animal> iDog = spDogs;
            IMyIfc<Animal> iAni = spDogs;

            PrintFirstItemName(iDog);
            PrintFirstItemName(iAni);

            Console.ReadKey();
        }
    }
}
