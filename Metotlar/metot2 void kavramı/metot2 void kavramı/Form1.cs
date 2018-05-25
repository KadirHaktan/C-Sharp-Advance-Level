using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace metot2_void_kavramı
{
    
    public partial class Form1 : Form
    {
        static void yaz(object x)
        {
            MessageBox.Show("girdiniz isim " + x);
        }
   
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            isim = textBox1.Text;
            yaz(isim);
        }
    }
}