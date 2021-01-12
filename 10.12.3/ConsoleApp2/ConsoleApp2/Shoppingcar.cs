using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingCart
{
    class shoppingcar
    {
        private static Dictionary<goods,int> shoppingList = null;
        public shoppingcar()
        {
            shoppingList = new Dictionart<goods,int>();
        }
        public void addShop(goods goods)
        {
            if (shoppingList.ContainsKey(goods))
            {
                shoppingList[goods] += 1;
            }
            else
            {
                shoppingList.Add(goods,1);
            }
           
            Console.WriteLine("添加{0}商品成功！", goods.goodsName);
        }
        public void shoeShoppingList()
        {
            Console.WriteLine("==================");
            Console.WriteLine("商品名称\t价格\t描述\t\t\t数量");
            foreach (goods item in shoppingList.Keys)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", item.goodsName, item.price, item.desc,shoppingList[item]);
            }
            Console.WriteLine("+==================");
        }
        public void removeShop(goods goods)
        {
            if (shoppingList[goods]>1)
            {
                shoppingList[goods]--;
            }
            else
            {
                shoppingList.Remove(goods);
            }
            
            Console.WriteLine("删除{0}商品成功！", goods.goodsName);
        }
    }
}
