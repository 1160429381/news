using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            dateTimePicker1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(textBox1.Text==" "|| textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " ||(radioButton1.Checked ==false ||radioButton2.Checked==false))
            {
                MessageBox.Show("存在值没有输入");
                return;
            }
            string sex = "女";
            if(radioButton1.Checked==true)
            {
                sex = "男";
            }
            string sql = string.Format("insert into Emp(emp_id,emp_name,emp_sex,emp_birthday,emp_phone,emp_email,emp_address");
                
        }

       
    }
 }
