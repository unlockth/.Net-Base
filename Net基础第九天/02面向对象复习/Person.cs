using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02面向对象复习
{
    class Person
    {

        //字段、属性、方法
        //字段：存储数据
        //属性：保护字段
        //方法：描述对象的一个行为

        string _name; // 默认为私有
        public string Name
        {
            get
            {
                if (_name != "孙权")
                {
                    _name = "孙权";
                }
                return _name;
            }
            set { _name = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 100 || value < 0)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        char _gender;
        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value != '男' && value != '女')
                {
                    value = '男';
                }
                _gender = value;
            }
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}，我是{2}生。", this.Name, this.Age, this.Gender);
        }
    }
}
