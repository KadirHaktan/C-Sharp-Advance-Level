using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sondan_karakter_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic, karakter;
            string metin;
            metin = textBox1.Text;
            karakter = Convert.ToInt32(textBox2.Text);

            baslangic = textBox1.Text.Length - karakter;

            

            label3.Text = metin.Substring(baslangic,karakter);
        }
    }
}