using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fonksiyon_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sonuc;
        void d_islem(string islem)
        {
           

            if(islem=="toplama")
            {
                sonuc = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            }

            if (islem == "çýkarma")
            {
                sonuc = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            }

            if (islem == "bölme")
            {
                sonuc = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            }

            if (islem == "çarpma")
            {
                sonuc = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
            }

            textBox3.Text = sonuc.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            d_islem(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d_islem(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d_islem(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d_islem(button4.Text);
        }
    }
}