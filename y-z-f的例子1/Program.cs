using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace y_z_f的例子1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(RefClass);
            MemberInfo[] minfos = t.GetMembers(BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Public|BindingFlags.DeclaredOnly| BindingFlags.Static);

            Func<MemberTypes, String> getType = (x) => 
            {
                switch(x)
                {
                    case MemberTypes.Field:
                        {
                            return "字段";
                        }
                    case MemberTypes.Method:
                        {
                            return "方法";
                        }
                    case MemberTypes.Property:
                        {
                            return "属性";
                        }
                    default:
                        {
                            return "未知";
                        }
                }
            };


            foreach(MemberInfo minfo in minfos)
            {
                Console.WriteLine(minfo.Name+"类型"+getType(minfo.MemberType));
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
