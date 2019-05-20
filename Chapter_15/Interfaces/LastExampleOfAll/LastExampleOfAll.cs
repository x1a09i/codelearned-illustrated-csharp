using System;

namespace LastExampleOfAll
{
    interface ILiveBirth { string BabyCalled(); }

    class Animal
    {
        protected string species;
        protected bool canLiveWithHuman;

        protected Animal(string species, bool canLiveWithHuman)
        {
            this.species = species;
            this.canLiveWithHuman = canLiveWithHuman;
        }

        protected void SayHello()
        {
            Console.WriteLine("Hi! I'm a {0}, I {1} live with human.",
                species,
                canLiveWithHuman
                ? "can"
                : "can't");
        }
    }

    class Lamu : Animal, ILiveBirth
    {
        public Lamu() : base("cat", true)
        {
            SayHello();
        }

        public string BabyCalled()
        {
            return "Nya!";
        }
    }

    class Lascu : Animal, ILiveBirth
    {
        public Lascu() : base("dog", true)
        {
            SayHello();
        }

        public string BabyCalled()
        {
            return "Won!";
        }
    }

    class Bird : Animal
    {
        protected bool canFly;

        public Bird(bool canFly) : base("bird", true)
        {
            this.canFly = canFly;
            SayHello();
        }

        new private void SayHello()
        {
            Console.WriteLine("Hi! I'm a {0}, I {1} live with human, And I {2} Fly",
                species,
                canLiveWithHuman
                ? "can"
                : "can't",
                canFly
                ? "can"
                : "can't");
        }
    }

    class LastExampleOfAll
    {
        static void Main(string[] args)
        {
            var animalArray = new Animal[3];
            animalArray[0] = new Lamu();
            animalArray[1] = new Lascu();
            animalArray[2] = new Bird(true);

            Console.WriteLine("\r\nNow, Let's Party!\r\n");

            foreach (Animal a in animalArray)
            {
                ILiveBirth b = a as ILiveBirth;
                if (null != b)
                    Console.WriteLine(b.BabyCalled());
                else
                    Console.WriteLine("Nothing but John Snow.");
            }

            Console.ReadKey();
        }
    }
}
