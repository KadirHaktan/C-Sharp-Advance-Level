using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            axWebBrowser1.Navigate(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWebBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWebBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWebBrowser1.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWebBrowser1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string k;

            if (File.Exists(@"C:\favori.txt"))                     //eğer böyle bir dosya varsa
            {
                StreamReader oku = File.OpenText(@"C:\favori.txt");   // dosyayı aç
                while (oku.EndOfStream == false)           // dosya sonuna kadar git yada oku.ReadLine()!= null
                {
                    k = oku.ReadLine();
                    if (string.Compare(k, textBox1.Text) == 0)
                    {
                        MessageBox.Show("Bu adres sık kullanılanlarda mevcut");
                        oku.Close();
                        return;
                    }

                }
                oku.Close();
                StreamWriter ekle = File.AppendText(@"C:\favori.txt");     //üzerine yazmak için dosyayı aç
                ekle.WriteLine(textBox1.Text);
                ekle.Close();
            }

            else
            {
                StreamWriter yaz = new StreamWriter(@"C:\favori.txt");    // yani dosya yap ve üstüne yaz
                yaz.WriteLine(textBox1.Text);
                yaz.Close();
 
            }


            //dosyada bulunan verileri ListBox üzerinde listeliyorum
            StreamReader liste = File.OpenText(@"C:\favori.txt");
            listBox1.Items.Clear();
            while (liste.EndOfStream == false)
            {
                listBox1.Items.Add(liste.ReadLine());
            }
            liste.Close();





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\favori.txt");
            string k;
            if (fi.Exists)//dosya varmı yokmu kontrolü
            {
                StreamReader oku = new StreamReader(@"C:\favori.txt");
                while ((k = oku.ReadLine()) != null)
                {
                    listBox1.Items.Add(k);

                }
                oku.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Silinecek kayıt yok");
                return;
            }
            
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);            //seçilen kaydı sil
            StreamWriter yaz = new StreamWriter(@"C:\favori.txt");      //dosyayı yeniden oluştur
            for (int i = 0; i<listBox1.Items.Count;i++)                   //listbox sonuna kadar dön
            {
                yaz.WriteLine(listBox1.Items[i].ToString());
                
            }
            yaz.Close();
        }



        private void axWebBrowser1_DownloadBegin(object sender, EventArgs e)
        {
            textBox1.Text = (axWebBrowser1.LocationURL.ToString());
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            button1_Click(sender, e);

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
	        {
                button1_Click(sender, e);
	        }
        }
    }
}
