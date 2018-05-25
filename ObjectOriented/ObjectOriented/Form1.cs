using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOriented
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBoxCinsiyet adındaki kontrolümüze liste seklinde veri ekle.
            comboBoxCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            comboBoxCinsiyet.SelectedIndex = 0;//secili satırı ilk index yap.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi mykisi = new Kisi();// Kisi sinifindan nesne üretildi.
            mykisi.Ad = txtAdi.Text;
            mykisi.Soyad = txtSoyadi.Text;
            mykisi.TcKimlikNo = txtTcKimlikNo.Text;
            mykisi.DogumTarii = dateTimePickerDogum.Value;
            MessageBox.Show(mykisi.KisiBilgileri());
        }
    }
}
