using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace System.Math_Sınıfı_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Math.Abs(10.5));//sayının mutlak değerini alır.
            listBox1.Items.Add(Math.Cos(40));//cosinus 
            listBox1.Items.Add(Math.Sin(70));//sinus 
            listBox1.Items.Add(Math.Tan(10));//tanjat değerini dondurur.
            listBox1.Items.Add(Math.Ceiling(4.2));// x i x den buyuk en kucuk tam sayıya dondurur.
            listBox1.Items.Add(Math.Floor(4.2));// x i x den kucuk en buyuktam sayıya dondurur.
            listBox1.Items.Add(Math.Max(4,5));// buyuk değerini donduren metot
            listBox1.Items.Add(Math.Min(4,2));// kucuk değerini donduren metot
            listBox1.Items.Add(Math.Pow(4,2));//üstü hesaplar.
            listBox1.Items.Add(Math.Sqrt(9));//karekok hesaplaması.

        }
    }
}