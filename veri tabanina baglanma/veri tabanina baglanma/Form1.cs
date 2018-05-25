using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.IO;
using System.Diagnostics;

namespace veri_tabanina_baglanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=C:\\Documents and Settings\\Administrator\\Belgelerim\\Veri tabaný\\vt2\\vt1.mdb");
        OleDbDataAdapter dt;
        DataSet ds;
        OleDbCommandBuilder cb;// bununa eklemek gerikir global olarak 
        public void guncelle()
        {
            ds.Tables[0].Clear();
            dt.Fill(ds, "tablo");

        }
        public void sonagit()

        { 
        CurrencyManager git;
        git = (CurrencyManager)this.BindingContext[ds.Tables[0]];
        git.Position = git.Count - 1;
        
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            dt = new OleDbDataAdapter("select kayitno,adisoyadi,telefon,adres,yas from tablo",baglanti);
            ds = new DataSet();
            dt.Fill(ds, "tablo");
            dataGridView1.DataSource = ds.Tables["tablo"];
            label5.DataBindings.Add("Text", ds.Tables[0], "kayitno");
            textBox1.DataBindings.Add("Text", ds.Tables[0], "adisoyadi");
            textBox2.DataBindings.Add("Text", ds.Tables[0], "telefon");
            textBox3.DataBindings.Add("Text", ds.Tables[0], "adres");
            textBox4.DataBindings.Add("Text", ds.Tables[0], "yas");
            sonagit();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrencyManager sonraki;
            sonraki = (CurrencyManager)this.BindingContext[ds.Tables[0]];
            sonraki.Position++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrencyManager onceki;
            onceki = (CurrencyManager)this.BindingContext[ds.Tables[0]];
            onceki.Position--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrencyManager ilk;
            ilk = (CurrencyManager)this.BindingContext[ds.Tables[0]];
            ilk.Position = 0;
            MessageBox.Show("ÝLK KAYÝTTASÝNÝZ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrencyManager son;
            son = (CurrencyManager)this.BindingContext[ds.Tables[0]];
            son.Position = son.Count - 1;
            MessageBox.Show("SON KAYÝTTASÝNÝZ ?");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbParameter[] param = new OleDbParameter[4];
            OleDbCommand komut = new OleDbCommand("insert into tablo (adisoyadi,telefon,adres,yas) values(?,?,?,?)", baglanti);
            cb = new OleDbCommandBuilder(dt);// ekleme silme yapabilmak için bu komutun kullanýlmasi gedekir.
            baglanti.Open();

            param[0] = new OleDbParameter();
            param[1] = new OleDbParameter();
            param[2] = new OleDbParameter();
            param[3] = new OleDbParameter();

            param[0].Value = textBox1.Text;
            param[1].Value = textBox2.Text;
            param[2].Value = textBox3.Text;
            param[3].Value = textBox4.Text;
           
            

            komut.Parameters.Add(param[0]);
            komut.Parameters.Add(param[1]);
            komut.Parameters.Add(param[2]);
            komut.Parameters.Add(param[3]);
            
            komut.ExecuteNonQuery();
            MessageBox.Show("KAYDÝNÝZ EKLENDÝ");
            baglanti.Close();
            guncelle();
            CurrencyManager son;
            int sayi;
            son = (CurrencyManager)this.BindingContext[ds.Tables[0]];
            sayi = son.Count;
            son.Position = sayi - 1;
            sonagit();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbParameter[] param = new OleDbParameter[5];
            OleDbCommand komut = new OleDbCommand("update tablo set adisoyadi=?,telefon=?,adres=?,yas=? where kayitno=?", baglanti);
            baglanti.Open();
            param[0] = new OleDbParameter();
            param[1] = new OleDbParameter();
            param[2] = new OleDbParameter();
            param[3] = new OleDbParameter();
            param[4] = new OleDbParameter();

            param[0].Value = textBox1.Text;
            param[1].Value = textBox2.Text;
            param[2].Value = textBox3.Text;
            param[3].Value = textBox4.Text;
            param[4].Value = label5.Text;

            komut.Parameters.Add(param[0]);
            komut.Parameters.Add(param[1]);
            komut.Parameters.Add(param[2]);
            komut.Parameters.Add(param[3]);
            komut.Parameters.Add(param[4]);
            komut.ExecuteNonQuery();
            MessageBox.Show("KAYDÝNÝZ DEÐÝÞTÝRÝLDÝ");
            baglanti.Close();
            guncelle();
            sonagit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbParameter param = new OleDbParameter();
            OleDbCommand komut = new OleDbCommand("delete from tablo where kayitno=?", baglanti);
            param= new OleDbParameter();
            param.Value = label5.Text;
            komut.Parameters.Add(param);
            komut.ExecuteNonQuery();
            MessageBox.Show("KAYDÝNÝZ SÝLÝNDÝ");
            baglanti.Close();
            guncelle();
            sonagit();
        }

        
    }
}