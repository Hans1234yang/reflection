using System;

namespace as运算符
{
    //2.as运算符

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            if(a is B)
            {
                b = (B)a;     //由于a变量不是 B类型，所有 转化为b变量是无效的
            }
            else
            {
                b = null;
            }
            if(b ==null)
            {
                Console.WriteLine("a变量不能转化为B类型");
            }
        }
    }

    class A { }

    class B:A { }
}
