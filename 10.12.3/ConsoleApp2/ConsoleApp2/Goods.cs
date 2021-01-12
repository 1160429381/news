using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingCart
{
    class goods
    {
        public string goodsName;
        public double price;
        public string desc;
        public goods(string goodsName,double price,string desc)
        {
            this.goodsName = goodsName;
            this.price = price;
            this.desc = desc;
        }
    }
}
