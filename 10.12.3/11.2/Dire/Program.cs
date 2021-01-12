using System;
using System.Collections.Generic;
using System.IO;

namespace Dire
{
    class Program
    {
        public static Dictionary<int, string> list = new Dictionary<int, string>();
        static void Main(string[] args)
        {
          while(true)
            {
                Console.WriteLine("*********选择菜单*********");
                Console.WriteLine("|     1    |创建文件夹|");
                Console.WriteLine("|     2    |移动文件夹|");
                Console.WriteLine("|     3    |删除文件夹|");
                Console.WriteLine("|    其他  |    退出  |");
                Console.WriteLine("*********请选择*********");
                string lnpu = Console.ReadLine();
                if(lnpu=="1")
                {
                    //创建
                    getFileList();
                }
                else if (lnpu == "2")
                {
                    //移动
                    moveFile();
                }
                else if (lnpu == "3")
                {
                    //删除
                    deleteFile();
                }
                else
                {
                    break;
                }
            }
        }
        public static void getFileList()
        {
            Console.WriteLine("请输入要查看的目录：");
            string path = Console.ReadLine();
            if(Directory.Exists(path))
            {
                string[] fileList = Directory.GetFiles(path);
                Console.WriteLine("该目录下的文件");
                Console.WriteLine("****编号*********文件名*******");
                for (int i = 0; i < fileList.Length; i++)
                {
                    Console.WriteLine("|\t{0}\t{1}",(i+1),fileList[i]);
                    list.Add(i, fileList[i]);
                }
                Console.WriteLine("***************************");
            }
            else
            {
                Console.WriteLine("路径不存在");
            }
        }
        public static void deleteFile()//删除
        {
            Console.WriteLine("请输入删除的文件：");
            int numer = Convert.ToInt32(Console.ReadLine());
            if(list.ContainsKey(numer-1))
            {
                string path = list[numer - 1];
                File.Delete(path);
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("输入的编号有问题");
            }
        }
        public static void moveFile()
        {
            Console.WriteLine("请输入移动的文件编号");
            int number = Convert.ToInt32(Console.ReadLine());
            if(list.ContainsKey(number-1))
            {
                string path = list[number - 1];
                Console.WriteLine("输入移动后的新路径");
                string newPath = Console.ReadLine();
                string oldName = Path.GetDirectoryName(path);
                string moveNewPath = newPath + "\\" + oldName;
                File.Move(path, moveNewPath);
                Console.WriteLine("移动成功");
            }
            else
            {
                Console.WriteLine("编号不存在");
            }
        }
    }
}
