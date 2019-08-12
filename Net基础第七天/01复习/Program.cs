using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    public enum Gender
    {
        男,
        女
    }
    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //常量 枚举 结构 数组
            const int number = 10;

            //Gender gender = Gender.男;
            //string s = "男";

            //Gender g = (Gender)Enum.Parse(typeof(Gender), s);
            //Console.WriteLine(g);
            //Console.ReadKey();


            //Person zsPerson = new Person();
            //zsPerson._name = "张三";
            //zsPerson._age = 16;
            //zsPerson._gender = Gender.男;
            //Console.WriteLine("我叫{0}，我今年{1}，我是{2}生", zsPerson._name, zsPerson._age, zsPerson._gender);
            //Console.ReadKey();


            //数组：一次性存储多个相同类型的变量
            //int[] numbers = new int[10];
            //number[20] = 3;

            int[] nums = { 0, 12, 3, 4, 7, 93, 1 };
            Array.Sort(nums);
            Array.Reverse(nums);
            //升序排列
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    for (int j = 0; j < nums.Length-i-1; j++)
            //    {
            //        if (nums[j] > nums[j+1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+",");
            }
            Console.ReadKey();
        }
    }
}
