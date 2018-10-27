using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace y_z_f的例子2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(RefClass);

            FieldInfo[] finfos = t.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach(FieldInfo finfo in finfos)
            {
                Console.WriteLine("字段名{0},字段类型{1}", finfo.Name, finfo.FieldType.ToString());
            }
            Console.ReadKey();
        }
    }
    public class RefClass
    {
        private int test1;
        private int test2 { get; set; }
        protected int test3 { get; set; }
        public int test4 { get; set; }
        public void Show()
        {

        }

        private static void Show2()
        {

        }
        private static void Show3()
        {

        }
    }
}
