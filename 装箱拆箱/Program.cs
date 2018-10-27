using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            //值类型变成引用类型， 装箱
            object o = i;
            Console.WriteLine(o);
            //引用类型转化为  值类型  拆箱 
            int j = (int)o;
            Console.Read();
        }
    }
}
