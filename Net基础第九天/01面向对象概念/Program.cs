using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s; // 系统类
            //Person lisi; // 自定义类，没有赋值前为null，不在内存中占用空间，只有当这个对象new之后，才会在内存中占用空间
            ////创建Person类的对象
            ////注：类在内存中不占空间，对象初始化后在内存中占空间，可以通过打断点查看
            //Person sunquan = new Person(); // 初始化后字段在内存中占空间
            //sunquan._name = "孙权";
            //sunquan._age = 23;
            //sunquan._gender = '男';
            //sunquan.CHLSS();
            //Console.ReadKey();

            ////类型的静态方法直接通过类名调用
            //Person.StaticPrint();
            //Console.ReadKey();
            
            Person sunquan = new Person();
            sunquan.Name = "孙权";
            sunquan.Age = -23;
            sunquan.Gender = '春';
            sunquan.CHLSS();
            Console.ReadKey();

        }
    }
}
