using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Metin_işlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin1,metin2;
            int numara;
            metin1 = textBox1.Text;
            metin2 = textBox3.Text;
            numara = Convert.ToInt32(textBox2.Text);
            textBox1.Text = metin1.Insert(numara,metin2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Length.ToString();
        }
    }
}