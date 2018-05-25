using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Super_Sayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int toplam = 0,a;
            a = Convert.ToInt32(textBox1.Text);
            progressBar1.Maximum = a+1;
            for (int i = 1; i <= a; i++)
            {
                int sayı = Convert.ToInt32(label1.Text);
                sayı++;
                label1.Text = sayı.ToString();
                System.Windows.Forms.Application.DoEvents();
                progressBar1.Value++;
                toplam = 0;
                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                        toplam += k;
                   
                }
                       if (toplam == i)
                        listBox1.Items.Add(i.ToString());
            }
        }
    }
}