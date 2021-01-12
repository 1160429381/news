using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
           ArrayList list=new ArrayList();
            Class1 A1 = new Class1("花花", 50, "男");
            Class1 A2 = new Class1("草草", 20, "女");
            Class1 A3 = new Class1("玉玉", 30, "女");
            list.Add(A1);
            list.Add(A2);
            list.Add(A3);

            for (int i = 0; i < list.Count; i++)
            {
                Class1 c = list[i] as Class1;
                Console.WriteLine("姓名:{0}\t年龄{1}\t",c.Name,c.Age);
            }
            Console.WriteLine("在A1的位置插入A1后");
            list.Insert(1, A1);
            for (int i = 0; i < list.Count; i++)
            {
                Class1 c = list[i] as Class1;
                Console.WriteLine("序号：{0}\t姓名:{1}\t年龄{2}\t",i, c.Name, c.Age);
            }
            Console.WriteLine("删除A1后");
            list.Remove( A1);
            for (int i = 0; i < list.Count; i++)
            {
                Class1 c = list[i] as Class1;
                Console.WriteLine("序号：{0}\t姓名:{1}\t年龄{2}\t", i, c.Name, c.Age);
            }
            Console.WriteLine("删除0索引以后：");
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                Class1 c = list[i] as Class1;
                Console.WriteLine("序号：{0}\t姓名:{1}\t年龄{2}\t", i, c.Name, c.Age);
            }
            ArrayList list2 = new ArrayList();
            list2.Add("111");
            list2.Add("222");
            list2.Add("333");
            list2.Sort();
            list2.Reverse();
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            object obj = "abc";
            object obj1 = 111;
            object obj2 = A1;
            string str = (string)obj;
            string str1 = obj as string;
            Class1 cc = obj2 as Class1;
            Hashtable hs = new Hashtable();
            hs.Add(A1.Name, A1);
            hs.Add(A2.Name, A2);
            hs.Add(A3.Name, A3);
            Class1 c11 = hs[A1.Name] as Class1;
            Console.WriteLine(c11.Name);
            foreach (object item in hs.Keys)
            {
                string name = item as string;
                Class1 cus = hs[name] as Class1;
                Console.WriteLine("客户姓名：{0}\t年龄：{1}",cus.Name,cus.Age);
            }
            foreach (object item in hs.Values)
            {
                Class1 cuss = item as Class1;
                Console.WriteLine("客户姓名：{0}\t年龄：{1}", cuss.Name, cuss.Age);
            }
            hs.Remove(A1.Name);
            foreach (object item in hs.Values)
            {
                Class1 cuss = item as Class1;
                Console.WriteLine("客户姓名：{0}\t年龄：{1}", cuss.Name, cuss.Age);
            }
            if (hs.ContainsKey(A1.Name))
            {
                Class1 c = hs[A1.Name] as Class1;
                Console.WriteLine(c.Name);
            }
            else
                Console.WriteLine("不存在{0}这个键名", A1.Name);
            if(hs.ContainsValue(A1))
            {
                Class1 c = hs[A1.Name] as Class1;
                Console.WriteLine(c.Name);
            }
            else
                Console.WriteLine("不存在{0}这个A1对象",A1.Name);
        }
    }
}
