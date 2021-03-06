﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace y_z_f的例子3
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(RefClass);
            RefClass rc = new RefClass();
            rc.test4 = 3;

            FieldInfo[] fieldInfos = t.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach(FieldInfo finfo in fieldInfos)
            {
                Console.WriteLine("字段名称{0}，字段类型{1}，值为{2}",
                    finfo.Name,finfo.FieldType.ToString(),finfo.GetValue(rc));
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

        private static void Show2()
        {
        }

        public static void Show3()
        {
        }

        public void Show()
        {

        }
    }
}
