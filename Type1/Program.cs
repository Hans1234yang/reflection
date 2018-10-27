using System;
using System.Reflection;

namespace Type1
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取描述 MyClass类型的Type对象

            Type t = typeof(MyClass);

            Console.WriteLine("{0}",t.Name);

            MethodInfo[] mi = t.GetMethods();

            foreach(MethodInfo m in mi)
            {
                //返回方法的返回类型
                Console.WriteLine("返回类型是{0}",m.ReturnType.Name);

                //返回方法名
                Console.WriteLine("方法名是{0}",m.Name);
            }
        }
    }

    class MyClass
    {
        int x;
        int y;
        MyClass(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public int sum()
        {
            return x + y;
        }

        public  bool IsBetween(int i)
        {
            if(x<i&&i<y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
             
    }
}
