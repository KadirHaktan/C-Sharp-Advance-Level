using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oYuN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
            textBox1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = false;
            timer1.Start();
            
            int sayi;
            Random rastgele = new Random();
            sayi = rastgele.Next(1, 100);
            label1.Text = sayi.ToString();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int saniye;
            saniye = Convert.ToInt32(label8.Text);
            saniye--;
            label8.Text = saniye.ToString();
            if (saniye == 0)
            {
                timer1.Stop();
                textBox1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = true;
                label3.Text = "8";
                label5.Text = "100";
                label8.Text = "120";
                label7.Text = "......";
                textBox1.Text = " ";
                MessageBox.Show("Süreniz Bittiði Ýçin Oyunu Kaybettiniz");

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int tahmin, bizim, hak, puan;
                tahmin = Convert.ToInt32(label1.Text);
                bizim = Convert.ToInt32(textBox1.Text);
                hak = Convert.ToInt32(label3.Text);
                puan = Convert.ToInt32(label5.Text);
                if (bizim != tahmin)
                {
                    if (bizim < tahmin)
                    {
                        label7.Text = "Sayýyý Büyültün";
                    }
                    if (bizim > tahmin)
                    {
                        label7.Text = "Sayýyý Küçültün";
                    }
                    hak = hak - 1;
                    label3.Text = hak.ToString();
                    puan = puan - 10;
                    label5.Text = puan.ToString();
                    if (hak == 0)
                    {
                        timer1.Stop();
                        MessageBox.Show("Hakkýnýz Bitmiþtir");
                        button1.Enabled = true;
                        textBox1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        label3.Text = "8";
                        label5.Text = "100";
                        label8.Text = "120";
                        label7.Text = "......";
                        textBox1.Text = " ";
                    }
                }

                else
                {
                    timer1.Stop();
                    MessageBox.Show("Tebrikler Bildiniz");
                    button1.Enabled = true;
                    textBox1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    label3.Text = "8";
                    label5.Text = "100";
                    label8.Text = "120";
                    label7.Text = "......";
                    textBox1.Text = " ";

                }
            }
            else
            {
                MessageBox.Show("Lütfen Sayý Giriniz");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            label3.Text = "8";
            label5.Text = "100";
            label8.Text = "120";
            label7.Text = "......";
            textBox1.Text = " ";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char kb;
            kb = e.KeyChar;
            if ((kb >= (char)58) || (kb <= (char)47))
            {
                e.Handled = true;
            }
        }
    }
}