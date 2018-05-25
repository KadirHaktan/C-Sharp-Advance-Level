using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mesaj_kutuları_kullanım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tıklanan;
            tıklanan = MessageBox.Show("Çıkmak istiyormusunuz"/*mesaj*/, "çıkıs"/*Başlıktaki text*/,MessageBoxButtons.YesNo, MessageBoxIcon.Question/*button turu*/); //hangi buttona tıklandıpını tıklanan değişkenine atadık.
            if (tıklanan == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}