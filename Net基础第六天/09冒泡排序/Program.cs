using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 4, 5, 0, 3, 7, 8, 6, 9 };
            //升序排序
            Array.Sort(nums);
            //数组反转，达到降序排序目的
            Array.Reverse(nums);

            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
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
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
    }
}
