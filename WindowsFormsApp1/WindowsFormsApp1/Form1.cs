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

        String mytext = "";

        private void button1_Click(object sender, EventArgs e)
        {
            mytext += "1";
            textBox1.Text = mytext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mytext += "2";
            textBox1.Text = mytext;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mytext += "3";
            textBox1.Text = mytext;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mytext += "4";
            textBox1.Text = mytext;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mytext += "5";
            textBox1.Text = mytext;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mytext += "6";
            textBox1.Text = mytext;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mytext += "7";
            textBox1.Text = mytext;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mytext += "8";
            textBox1.Text = mytext;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mytext += "9";
            textBox1.Text = mytext;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mytext += "0";
            textBox1.Text = mytext;
        }

        private void button11_Click(object sender, EventArgs e)
        {
        
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            mytext += "+";
            textBox1.Text = mytext;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            mytext += "x";
            textBox1.Text = mytext;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mytext += "/";
            textBox1.Text = mytext;
        }
    }
}
