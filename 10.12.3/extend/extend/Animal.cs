using System;
using System.Collections.Generic;
using System.Text;

namespace extend
{
    class Animal
    {
        public string name;
        public char sex;
        public string color;
        public Animal (string name,char sex,string color)
        {
            this.name = name;
            this.sex = sex;
            this.color = color;
        }
        public void sound()
        {
            Console.WriteLine("Animal类的输出：{0},{1},{2}",name,sex,color);
        }
    }
}
