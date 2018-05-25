using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] yenidizi = new int[5];
            Random rastgele = new Random();
            for (int i = 0; i < 5; i++)
            {
                yenidizi[i] = rastgele.Next(1, 100);
                listBox1.Items.Add(yenidizi[i].ToString());
            }

        }
    }
}