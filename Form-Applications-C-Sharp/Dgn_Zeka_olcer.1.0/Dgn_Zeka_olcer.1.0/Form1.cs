using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zeka_olcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 int s1, s2, s3, s4,toplam,bul,sn;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            timer1.Start();
            Random rastgele = new Random();
           
            toplam = 0;
            
            s1 = rastgele.Next(1, 100);
            
            s2 = rastgele.Next(1, 100);
            
            s3 = rastgele.Next(1, 100);
           
            s4 = rastgele.Next(1, 100);
           
            toplam = s1 + s2 + s3 + s4;

            label1.Text = Convert.ToString(s1);
            label2.Text = Convert.ToString(s2);
            label3.Text = Convert.ToString(s3);
            label4.Text = Convert.ToString(s4);
            

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            sn = Convert.ToInt32(label7.Text);
            sn++;
            label7.Text = Convert.ToString(sn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bul = Convert.ToInt32(textBox1.Text);
            if (toplam == bul)
            {
                timer1.Stop();
                if (sn <= 20)
                {
                    MessageBox.Show("Tebrikler " + label7.Text + " Saniyede Bildiniz\n Süper Zekasınız");
                }
                else
                {
                    MessageBox.Show("Tebrikler " + label7.Text + " Saniyede Bildiniz\n Zekanızı Biraz Daha Zorlamalısınız!");
                }
              
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}
