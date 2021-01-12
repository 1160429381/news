using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static ArrayList studentList;
        public Form1()
        {
            InitializeComponent();
            studentList = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double score = double.Parse(textBox2.Text);
            string grades = textBox3.Text;
            studentList.Add(name);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(studentList.ToArray());
        }
    }
}
