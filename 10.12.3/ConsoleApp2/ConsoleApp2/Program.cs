using shoppingCart;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            shoppingcar sc = new shoppingcar();
            goods shoes = new goods("雪地靴", 299.5, "穿好了之后在地上走");
            goods cloth = new goods("冬装", 29.9, "冬天有了它就不冷");
            goods hams = new goods("手套", 9.9, "加厚版手套");
            sc.addShop(shoes);
            sc.addShop(cloth);
            sc.addShop(hams);
            sc.addShop(hams);
            sc.addShop(hams);
            sc.shoeShoppingList();
            sc.removeShop(hams);
            sc.removeShop(cloth);
            sc.shoeShoppingList();

            //Hashtable hs = new Hashtable();
            //hs.Add();

            //Dictionary<string,goods>
        }
    }
}
