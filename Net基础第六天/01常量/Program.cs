using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01常量
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 30;// 这个变量声明之后可以修改
            number = 20;

            const int numberTwo = 50;// 这个变量声明之后不可以修改
            Console.WriteLine("这是一个变量："+number);
            Console.WriteLine("这是一个常量：" + numberTwo);
            Console.ReadKey();
        }
    }
}
