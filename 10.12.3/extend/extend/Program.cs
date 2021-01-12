using System;

namespace extend
{
    class Program
    {
        class Dog
        {
            public string name;
            private int age;
            protected string color;
            internal double weight;
            public Dog()
            {
                this.name = "小狗狗";
                this.age = 10;
                this.color = "黑色";
                this.weight = 10;
            }
        }
        class IittleDog : Dog
        {
            public string type;
            public IittleDog()
            {
                this.name = "小狗狗";
                this.age = 2;
            }
        }
        static void Main(string[] args)
        {

            Bird b = new Bird("喜鹊", '公', "蓝灰", "一双喜鹊");
            b.sound();
            Animal a = new Bird("喜鹊", '公', "蓝灰", "一双喜鹊");
            a.sound();


            //Hr h = new Hr("张三", '女', 3);
            ////Hr h = new Hr();
            ////{
            ////    name = "张三",
            ////    sex = '女',
            ////    WorkAge = 3
            ////};
            //h.meeting();
            //h.hiring();
            //Progammer p = new Progammer();
            ////p.meeting();
            //p.WokSoft();
            //SellMan sm = new SellMan();
            ////sm.meeting();
            //sm.sellsoft();
        }
    }
}
