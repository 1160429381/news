using System;
using System.Collections.Generic;
using System.Text;

namespace extend
{
    class Employee
    {
        //
        public string name;
        public char sex;
        public int WorkAge;
        public  Employee(string name, char sex, int workAge)
        {
            this.name = name;
            this.sex = sex;
            this.WorkAge = workAge;
            //Console.WriteLine("父类的构造方法");
        }
        public void meeting()
        {
            Console.WriteLine("我可以开会！");
        }
    }
}
