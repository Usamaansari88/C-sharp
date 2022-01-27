using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            int sum;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            sum = b + a ;
            //textBox3.Text =sum.ToString(); 
            label1.Text = Convert.ToString(  sum);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            int sub;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            sub = b - a;
            textBox3.Text = sub.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            int mul;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            mul = b * a;
            textBox3.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            int div ;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            div = b / a;
            textBox3.Text = div.ToString();
        }
    }
}
