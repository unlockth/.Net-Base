
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "张三";
            p1.Age = -10;
            p1.Gender = '男';
            p1.SayHello();


            Person p2 = new Person();
            p2.Name = "李四";
            p2.Age = 18;
            p2.Gender = '中';
            p2.SayHello();

            Console.ReadKey();
        }
    }
}
