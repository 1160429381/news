using System;
using System.Collections.Generic;
using System.Text;

namespace extend
{
    class Hr:Employee
    {
        public  Hr(string name, char sex, int workAge):base(name,sex,workAge)
        {
            Console.WriteLine("HR类的无参构造方法");
        }
        //public Hr(string name, char sex, int workAge):this()
        //{
        //    this.name = name;
        //    this.sex = sex;
        //    this.WorkAge = workAge;
        //}
        public void hiring()
        {
            Console.WriteLine("我可以招聘!我的名字：{0}，性别{1}，工龄{2}",this.name,sex,WorkAge);
        }
    }
}
