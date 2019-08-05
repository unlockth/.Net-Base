using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02枚举
{
    public enum Gender
    {
        男,
        女
    }
    public enum Seasons
    {
        春,
        夏,
        秋,
        东
    }
    public enum QQState
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            //变量类型 变量名 = 值
            Gender gender = Gender.男;


            Seasons s = Seasons.春;
            QQState state = QQState.OnLine;
            Console.WriteLine(state);
            Console.ReadKey();
        }
    }
}
