using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tutulan;
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            textBox1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            Random rastgele = new Random();
            tutulan = rastgele.Next(1, 100);
            label8.Text = Convert.ToString(tutulan);
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            label8.Visible = false;
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sn;
            sn = Convert.ToInt32(label7.Text);
            sn--;
            label7.Text = Convert.ToString(sn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int  tahmin, hak, puan;

                
                tahmin = Convert.ToInt32(textBox1.Text);
                hak = Convert.ToInt32(label4.Text);
                puan = Convert.ToInt32(label5.Text);

                if (tutulan < tahmin)
                {
                    puan = puan - 10;
                    hak = hak - 1;
                    label6.Text = "Sayınızı Küçültün";
                    label4.Text = Convert.ToString(hak);
                    label5.Text = Convert.ToString(puan);
                }
                else
                {
                    puan = puan + 10;
                    hak = hak - 1;
                    label6.Text = "Sayınızı Büyültün";
                    label4.Text = Convert.ToString(hak);
                    label5.Text = Convert.ToString(puan);
                }
                if (tutulan == tahmin)
                { 
                    timer1.Stop();
                    MessageBox.Show(" TEBRİKLER \n" + label4.Text + " Hakla \n" + label7.Text + " Saniyede \n" + label5.Text + " Puanla Bildiniz \n");
                    label7.Text = "120";
                    label4.Text = Convert.ToString(hak);
                    label5.Text = Convert.ToString(puan);
                    label6.Text = "";
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    button3.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = false;
                    label8.Text = "";
                    
                }
                if (hak == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Üzgünüz :( Hakkınız BİTTİ");
                    label7.Text = "120";
                    label4.Text = "8";
                    label5.Text = "300";
                    label6.Text = "";
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    button3.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = false;
                    label8.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "120";
            textBox1.Enabled = false;
            textBox1.Text = "";
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
