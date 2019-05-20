using System;

namespace Enumerations
{
    enum TrafficLights
    {
        // 成员之间用逗号分隔
        Green,
        Yellow,
        // 枚举类型不需要用分号结尾
        Red
    }

    enum TrafficLights2
    {
        // 成员之间用逗号分隔
        Green,
        Yellow,
        // 枚举类型不需要用分号结尾
        Red
    }
    class Enumerations
    {
        static void Main(string[] args)
        {
            TrafficLights t1 = TrafficLights.Green;
            TrafficLights t2 = TrafficLights.Yellow;
            TrafficLights t3 = TrafficLights.Red;
            // 你也可以在枚举类型间进行赋值操作
            TrafficLights t4 = t3;

            // 此处用到了强制类型转换运算符，来输出枚举的底层类型（underlying type）
            Console.WriteLine("{0},\t{1}", t1, (int)t1);
            Console.WriteLine("{0},\t{1}", t2, (int)t2);
            Console.WriteLine("{0},\t{1}", t3, (int)t3);
            Console.WriteLine("{0},\t{1}", t4, (int)t4);

            Console.ReadKey();
        }
    }
}
