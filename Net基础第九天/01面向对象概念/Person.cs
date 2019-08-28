using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象
{
    class Person
    {
        private string _name;

        public string Name
        {
            //当你输出属性值的时候 会执行get方法
            get { return _name; }
            //当你给属性赋值的时候 首先会执行set方法
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }



        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁，我是{2}生，我喜欢吃喝拉撒睡~~~", this.Name, this.Age, this.Gender);
        }

        public static void StaticPrint()
        {
            Console.WriteLine("静态方法使用类名直接调用。");
        }
    }
}
