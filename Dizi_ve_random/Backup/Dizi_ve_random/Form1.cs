using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dizi_ve_random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rasgele_sayi = new Random();

        int[] zar_dizisi = new int[20];
      
        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk;
            listBox1.Items.Clear();
            for (uzunluk = 0; uzunluk < 20; uzunluk++)
            {
                zar_dizisi[uzunluk] = rasgele_sayi.Next(1, 7);
                listBox1.Items.Add((uzunluk+1).ToString()+". zar = "+zar_dizisi[uzunluk]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no;
            no = Convert.ToInt32(textBox1.Text);
            label3.Text = zar_dizisi[no-1].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}