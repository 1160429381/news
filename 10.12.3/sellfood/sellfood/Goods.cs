using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sellfood
{
    class Goods
    {
        private int id;
        private string goodName;
        private double price;
        private string desc;
        private int goodNum;
        public int Id { get => id; set => id = value; }
        public string GoodName { get => goodName; set => goodName = value; }
        public double Price { get => price; set => price = value; }
        public string Desc { get => desc; set => desc = value; }
        public int GoodNum { get => goodNum; set => goodNum = value; }

        public Goods(int id,string goodsName,double prrice,string desc)
        {
            this.id = id;
            this.goodName = goodsName;
            this.price = prrice;
            this.desc = desc;

        }

    }
}
