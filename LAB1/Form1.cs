using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double plus(double a, double b)
        {
            return a + b;
        }

        public static double razn(double a, double b)
        {
            return a - b;
        }

        public static double umnog(double a, double b)
        {
            return a * b;
        }

        public static double del(double a, double b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(plus(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(razn(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(umnog(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
    }
}

  
