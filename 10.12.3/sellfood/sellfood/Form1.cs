using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellfood
{
    public partial class Form1 : Form
    {
        private static List<Goods> shoppingList = null;
        private static Dictionary<string, Goods> shoppingCar = null;
        public Form1()
        {
            InitializeComponent();
            shoppingList = new List<Goods>();
            shoppingCar = new Dictionary<string, Goods>();
            Goods food1 = new Goods(0, "辣条炒饭", 25.5, "吃了还正常");
            Goods food2 = new Goods(1, "辣条火锅", 35.5, "吃了还回头");
            Goods food3 = new Goods(2, "辣条拌饭", 25.5, "吃了还想吃");
            Goods food4 = new Goods(3, "辣条炒粉", 15.5, "价格实惠");
            shoppingList.Add(food1);
            shoppingList.Add(food2);
            shoppingList.Add(food3);
            shoppingList.Add(food4);
            foreach (Goods item in shoppingList)
            {
                ListViewItem lv = new ListViewItem();
                lv.ImageIndex = item.Id;
                lv.Text = item.GoodName + " " + item.Price;
                listView1.Items.Add(lv);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0)
            {
                return;
            }
            string goodsName = listView1.SelectedItems[0].Text;
            foreach (Goods item in shoppingList)
            {
                if((item.GoodName+" "+item.Price)==goodsName)
                {
                    label2.Text = item.GoodName;
                    label4.Text = item.Price.ToString();
                    textBox1.Text = item.Desc;
                    pictureBox1.Image = Image.FromFile("images/" + item.Id + ".jpg");
                }
            }
        }

        private void gwc_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("请选择菜品！");
                return;
            }
            string goodsName = label2.Text;
            Goods selectedFood = null;
            foreach (Goods item in shoppingList)
            {
                if (item.GoodName==goodsName)
                {
                    selectedFood = item;
                }
            }
            if (shoppingCar.ContainsKey(goodsName))
            {
                shoppingCar[goodsName].GoodNum++;
            }
            else
            {
                shoppingCar.Add(goodsName, selectedFood);
                shoppingCar[goodsName].GoodNum = 1;
            }
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = shoppingCar.Values.ToList();
        }
    }
}
