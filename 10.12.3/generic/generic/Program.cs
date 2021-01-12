using System;
using System.Collections;
using System.Collections.Generic;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("小明", 20, '男');
            ArrayList list = new ArrayList();
            list.Add("abc");
            list.Add(111);
            list.Add(c1);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<string> list2 = new List<string>();
            list2.Add("abc");
            list2.Add("bac");
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            //objectClass<string> obj = new objectClass<string>("abc");
            //Console.WriteLine(obj.val);
            //Customer c1 = new Customer("小明", 20, '男');
            //objectClass<Customer> obj2 = new objectClass<Customer>(c1);
            //Console.WriteLine(obj2.val.name);
        }
        class objectClass<T>
        {
          public   T val;
            public objectClass (T val)
            {
                this.val = val;
            }
        }
        class intClass
        {
            int val;
            public intClass(int val)
            {
                this.val = val;
            }

        }
        class stringClass
        {
            string val;
            public stringClass(string val)
            {
                this.val = val;
            }
        }
        
    }
}
