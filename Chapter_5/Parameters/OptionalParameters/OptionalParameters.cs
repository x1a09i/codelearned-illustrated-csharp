using System;

namespace OptionalParameters
{
    class OptionalParameters
    {
        int test;
        double GetCylinderVolume(double radius = 3.0, double height = 4.0)
        {
            void main2()
            {
                Console.WriteLine("nestes");
            }

            main2();

            return 3.1416 * radius * radius * height;
        }

        static void Main(string[] args)
        {
            OptionalParameters pg = new OptionalParameters();
            double volume;

            // 位置参数
            volume = pg.GetCylinderVolume(5.0, 5.0);
            Console.WriteLine("Volume = " + volume);

            // 命名参数 + 可选参数 使用height的默认值
            volume = pg.GetCylinderVolume(radius: 2.0);
            Console.WriteLine("Volume = " + volume);

            // 命名参数 + 可选参数 使用radius的默认值
            volume = pg.GetCylinderVolume(height: 2.0);
            Console.WriteLine("Volume = " + volume);

            // 可选参数 使用所有的缺省值
            volume = pg.GetCylinderVolume();
            Console.WriteLine("Volume = " + volume);

            Console.ReadLine();
        }
    }
}
