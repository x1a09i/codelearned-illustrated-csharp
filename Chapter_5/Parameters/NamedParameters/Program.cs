using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        double GetCylinderVolume(double radius, double height)
        {
            return 3.1416 * radius * radius * height;
        }

        static void Main(string[] args)
        {
            // 注意：此处在类自己的函数成员内，创建了一个类本身的实体
            Program pg = new Program();
            double volume;

            volume = pg.GetCylinderVolume(3.0, 4.0);
            // 命名参数让程序看起来更加直观，亦可防止疏漏
            volume = pg.GetCylinderVolume(radius: 3.0, height: 4.0);

            Console.WriteLine(volume);
            Console.ReadLine();
        }
    }
}
