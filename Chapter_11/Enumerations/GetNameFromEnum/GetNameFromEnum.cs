using System;

namespace GetNameFromEnum
{
    enum TrafficLights
    {
        Green,
        Yellow,
        Red,
        White,
        WhatTheFuckIsWhite
    }
    class GetNameFromEnum
    {
        static void Main(string[] args)
        {
            // 注意此处用到了typeof方法
            Console.WriteLine("The Final Member of TrafficLights is {0}\n",
                Enum.GetName(typeof(TrafficLights), TrafficLights.WhatTheFuckIsWhite));

            foreach (var name in Enum.GetNames(typeof(TrafficLights)))
                Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
