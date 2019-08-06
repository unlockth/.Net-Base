using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组类型[] 数组名=new 数组类型[数组长度]
            int[] nums = new int[10]; // 数组初始没有设置值，默认每一个元素的值为0
            //数组的声明方式
            int[] numsTwo = { 1, 2, 3, 4 };

            int[] numsThree = new int[3] { 1, 2, 3 }; // 数组指定的长度必须与{}中的值长度一致

            int[] numsFour = new int[] { 1, 2, 3, 4 };
            //nums[0] = 1;
            //nums[1] = 2;
            //nums[2] = 3;
            //nums[3] = 4;
            //nums[4] = 5;
            //nums[5] = 6;
            //nums[6] = 7;
            //nums[7] = 8;
            //nums[8] = 9;
            //nums[9] = 10;
            //nums[10] = 11; // 超出数组索引，会报错

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();


            //注：null表示在内存中不占用空间，""空字符串是占用空间的
            string[] str = new string[10]; // 初始没有设置值，默认每一个元素为null

            bool[] bools = new bool[10]; // 初始没有设置值，默认每一个元素为false
            for (int i = 0; i < bools.Length; i++)
            {
                Console.WriteLine(bools[i]);
            }
            Console.ReadKey();
        }
    }
}
