using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Sıkıştırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSikistirma_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Sikistirma(ofd.FileName, sfd.FileName);
                }
            }

        }

        void Sikistirma(string yol, string KaydedilecekYer)
        {
            FileStream sikistirilacakDosya = new FileStream(yol, FileMode.Open,FileAccess.Read);
            byte[] veriler = new byte[sikistirilacakDosya.Length];
            sikistirilacakDosya.Read(veriler, 0, veriler.Length);
            sikistirilacakDosya.Close();
            FileStream Kaydetme = new FileStream(KaydedilecekYer, FileMode.Create, FileAccess.Write);
            GZipStream sikistirma = new GZipStream(Kaydetme,CompressionMode.Compress);
            sikistirma.Write(veriler,0,veriler.Length);
            sikistirma.Close();

        }
        void Ac(string yol, string KaydedilecekYer)
        {
            FileStream sikistirilmisDosya = new FileStream(yol, FileMode.Open, FileAccess.Read);
            GZipStream acma = new GZipStream(sikistirilmisDosya, CompressionMode.Decompress);
            byte[] veriler = new byte[9999999];
            int uzunluk = acma.Read(veriler, 0, veriler.Length);
            acma.Close();
            byte[] yazilacak = new byte[uzunluk];
            Array.Copy(veriler, yazilacak, yazilacak.Length);
            FileStream Kaydetme = new FileStream(KaydedilecekYer, FileMode.Create, FileAccess.Write);
            Kaydetme.Write(yazilacak,0,yazilacak.Length);
            Kaydetme.Close();
             
           

            
           

        }


        private void btnAc_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Sikistirma(ofd.FileName, sfd.FileName);
                }
            }
        }
    }
}
