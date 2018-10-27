using System;

namespace is运算符
{
    class Program
    {
        // 1. is 运算符


        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            if(a is A)
            {
                Console.WriteLine("a 对象与A类兼容");
            }

            if(b is A)
            {
                Console.WriteLine("b对象与 A类兼容");
            }
            if(a is B)
            {
                Console.WriteLine("a对象与B类兼容");
            }
            if(a is object)
            {
                Console.WriteLine("a对象与 object类兼容");
            }
        }
    }

    class A { }

    class B:A { }

}
