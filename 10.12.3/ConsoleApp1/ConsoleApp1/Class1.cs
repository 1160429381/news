using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   class Class1
    {
        private string name;
        private int age;
        private string sex;
      
        public Class1( string name,int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
       
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
