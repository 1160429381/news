using System;
using System.Collections.Generic;
using System.Text;

namespace extend
{
    class Bird:Animal
    {
        public string wing;
        public Bird(string name,char sex,string color,string wing):base(name,sex,color)
        {
            this.wing = wing;
        }
        public void sound()
        {
            Console.WriteLine("{0},{1},{2},{3}",name,sex,color,wing);
        }
    }
}
