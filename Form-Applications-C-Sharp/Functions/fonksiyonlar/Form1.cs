using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fonksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sonuc = 0;
        public int  karesi (string kresi)
        {
            sonuc = Convert.ToInt32(kresi);
            sonuc = sonuc * sonuc;
            return sonuc;
            
        }
        
        public int Kupu(string küp)
        {
            sonuc = Convert.ToInt32(küp);
            sonuc = sonuc * sonuc * sonuc;
            return sonuc;
        }
        public int kat(string kt)
        {
            sonuc = Convert.ToInt32(kt);
            sonuc = sonuc * 2;
            return sonuc;
        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            karesi(textBox1.Text);
            textBox1.Text = sonuc.ToString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Kupu (textBox2.Text);
            textBox2.Text = sonuc.ToString();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            kat(textBox3.Text);
            textBox3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            karesi(textBox4.Text);
            textBox4.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kupu(textBox5.Text);
            textBox5.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kat(textBox6.Text);
            textBox6.Text = sonuc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            karesi(textBox7.Text);
            textBox7.Text = sonuc.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kupu(textBox8.Text);
            textBox8.Text = sonuc.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kat(textBox9.Text);
            textBox9.Text = sonuc.ToString();
        }
    }
}