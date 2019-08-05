using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03枚举类型的和string以及int类型之间的转换
{
    /// <summary>
    /// QQ状态
    /// </summary>
    public enum QQState
    {
        OnLine,
        //OnLine = 2,
        OffLine,
        Leave,
        //Leave =5,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转成int类型
            //QQState state = QQState.OnLine;
            ////枚举类型默认可以跟int类型互相转换  枚举类型跟int类型是兼容的
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion

            #region 将int类型强转为枚举类型
            //int n1 = 3;
            ////int n1 = 8;
            //QQState state = (QQState)n1;
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion


            #region 将枚举类型转换成字符串类型
            //所有类型都能转换为string类型，调用toString
            //int n1 = 10;
            //double n1 = 3.14;
            //decimal n1 = 5000m;
            //string s = n1.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();

            //QQState state = QQState.OnLine;
            //string s = state.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();
            #endregion


        }
    }
}
