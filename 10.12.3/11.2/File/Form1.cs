using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                FileStream fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                textBox2.Text = sr.ReadToEnd();
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
                MessageBox.Show("读取文件了");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先选择需要保存的文件");
                return;
            }
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(textBox1.Text, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(textBox2.Text);
                sw.Close();
                MessageBox.Show("保存文件成功");
            }
            else
            {
                MessageBox.Show("保存文件失败");
            }
        }
    }
}
