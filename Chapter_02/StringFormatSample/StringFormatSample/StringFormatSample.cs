using System;

namespace StringFormatSample
{
    /// <summary>
    /// 使用C#格式化字符串&格式化数字字符串的示例代码
    /// </summary>
    class StringFormatSample
    {
        static void Main(string[] args)
        {
            /* 格式化字符串&替代标记的使用：
             * 替代值的个数可以超出替代位置的范围，然而替代位置的范围不能大于替代值的总数 */
            Console.WriteLine("Two integers are {0} and {1}.", 3, 6, 9);

            // 对齐说明符
            Console.WriteLine("|{0, 10}|", 500);
            Console.WriteLine("|{0,-10}|", 500);

            // 9种格式说明符&精度说明符（九头龙闪！）

            /* 1.C,c - 货币:货币符号取决于运行环境的区域设置。
             * 精度说明符:小数位数 */
            Console.WriteLine("|{0,10:C3}|", 123.45);

            /* 2.D,d - 十进制数:只能配合整数，可以使用负数 
             * 精度说明符:最少输出位数，位数不够时将在左端以0填充 */
            Console.WriteLine("|{0,10:d3}|", -13);

            /* 3.F,f - 定点小数:可以使用负数
             * 精度说明符:小数位数，位数不够时将以0填充，位数超过时默认四舍五入 */
            Console.WriteLine("|{0,10:f3}|", -13.2467);

            /* 4.G,g - 缺省时的默认格式说明符，根据数值自动转换为定点小数或科学计数法
             * 精度说明符:依值而定 */
            Console.WriteLine("|{0,10:G4}|", 13.2467);

            /* 5.X,x - 十六进制数:区分大小写
             * 精度说明符:最少输出位数，位数不够时将以0填充 */
            Console.WriteLine("|{0,10:x4}|", 213);
            Console.WriteLine("|{0,10:X4}|", 1213);

            /* 6.N,n - 与定点小数相似，但是每三个数字带间隔符。间隔符为空格或逗号，根据运行环境的区域设置决定
             * 精度说明符:小数位数 */
            Console.WriteLine("|{0,10:n1}|", 112358);

            /* 7.P,p - 百分比:将数字乘以100后带百分比符号输出
             * 精度说明符:小数位数 */
            Console.WriteLine("|{0,10:p3}|", 0.3457);

            /* 8.R,r - 往返过程:其用法与Parse方法关联，具体参见25章
             * 精度说明符:缺省 */
            Console.WriteLine("|{0,10:r3}|", 0.3457);

            /* 9.E,e - 科学计数法:区分大小写
             * 精度说明符:(作为底数的)小数位数 */
            Console.WriteLine("|{0,10:E4}|", 12.3456);
            Console.WriteLine("|{0,10:e3}|", 12.3456);

            Console.ReadLine();
        }
    }
}
