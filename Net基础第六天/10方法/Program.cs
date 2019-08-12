using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法就是为了解决代码中的冗余或重复问题
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("暂停");
            //Console.WriteLine("改变大小");
            //Console.WriteLine("改变形状");
            //Console.WriteLine("恢复");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("暂停");
            //Console.WriteLine("改变大小");
            //Console.WriteLine("改变形状");
            //Console.WriteLine("恢复");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("暂停");
            //Console.WriteLine("改变大小");
            //Console.WriteLine("改变形状");
            //Console.WriteLine("恢复");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("暂停");
            //Console.WriteLine("改变大小");
            //Console.WriteLine("改变形状");
            //Console.WriteLine("恢复");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");
            //Console.WriteLine("前进前进前进！！！");

            Program.PlayGame();
            Program.WuDi();
            Program.PlayGame();
            Program.PlayGame();
            Program.PlayGame();
            Program.WuDi();
            Program.PlayGame();
            Program.PlayGame();
            Console.ReadKey();
        }
        /// <summary>
        /// 正常玩游戏
        /// </summary>
        public static void PlayGame()
        {
            Console.WriteLine("前进前进前进！！！");
            Console.WriteLine("前进前进前进！！！");
            Console.WriteLine("前进前进前进！！！");
            Console.WriteLine("前进前进前进！！！");
        }
        /// <summary>
        /// 无敌
        /// </summary>
        public static void WuDi()
        {
            Console.WriteLine("暂停");
            Console.WriteLine("改变大小");
            Console.WriteLine("改变形状");
            Console.WriteLine("恢复");
        }
    }
}
