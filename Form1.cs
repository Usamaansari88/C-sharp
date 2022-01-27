using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student std = new student();
            string nam = textBox1.Text;
            int ro = int.Parse(textBox2.Text);
            string sec = textBox3.Text;
            std.set(nam, ro, sec);

            Form1 f1 = new Form1();
            Form2 f2 = new Form2(std);
            this.Hide();
            f2.Show();
        }
    }
}
