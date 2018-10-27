using System;
using System.Text;

namespace typeof运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(StringBuilder);

            //返回fullname属性
            Console.WriteLine(t.FullName);
            if(t.IsClass)
            {
                Console.WriteLine("是一个类");
            }

            //是否为密封类
            if(t.IsSealed)
            {
                Console.WriteLine("是一个密封类");
            }
            Console.ReadLine();

        }
    }
}
