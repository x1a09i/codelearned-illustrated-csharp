using System;

namespace LambdaExpression
{
    delegate double MyDelegate(int par);

    class LambdaExpression
    {
        static void Main(string[] args)
        {
            // 匿名方法（谁用谁傻叉）
            MyDelegate mdMethod = delegate (int x) { return x + 1; };

            // Lambda神功，第1层：驱除delegate关键字，引入大杀器 "=>"
            MyDelegate mdLambdaLv1 = (int x) => { return x + 1; };
            // Lambda神功，第2层：驱除类型
            MyDelegate mdLambdaLv2 = (x) => { return x + 1; };
            // Lambda神功，第3层：驱除括号
            MyDelegate mdLambdaLv3 = x => { return x + 1; };
            // Lambda神功，第4层：仅用表达式返回
            MyDelegate mdLambdaLv4 = x => x + 1;

            Console.WriteLine("{0}", mdMethod(12));

            Console.WriteLine("{0}", mdLambdaLv1(12));
            Console.WriteLine("{0}", mdLambdaLv2(12));
            Console.WriteLine("{0}", mdLambdaLv3(12));
            Console.WriteLine("{0}", mdLambdaLv4(12));

            Console.ReadKey();
        }
    }
}
