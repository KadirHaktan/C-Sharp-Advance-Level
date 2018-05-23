using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data.SqlClient;

namespace TELEFON_REHBERI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        } 

        private OracleConnection baglanti = new OracleConnection();
        private OracleCommand cmd;
        private OracleDataAdapter da;
        private OracleCommandBuilder cb;
        private DataSet ds;

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST =(ADDRESS = (COMMUNITY = tcp.world)(PROTOCOL = TCP)(Host = 192.168.2.145)(Port = 1521)))(CONNECT_DATA = (SID = INT)));user id=INT;password=delidumrul";
            try
            {
                baglanti.Open();
                string sql = "select * from TELEFON_REHBERI";
                cmd = new OracleCommand(sql, baglanti);
                cmd.CommandType = CommandType.Text;
                da = new OracleDataAdapter(cmd);
                cb = new OracleCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);

                grd_tablo.DataSource = ds.Tables[0];

                grd_tablo.DefaultCellStyle.SelectionBackColor = Color.Green;
                grd_tablo.DefaultCellStyle.SelectionForeColor = Color.White;
                grd_tablo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9, FontStyle.Bold);
                grd_tablo.EnableHeadersVisualStyles = false;
                grd_tablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
                grd_tablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
               
                

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void grd_tablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili_deger = grd_tablo.CurrentRow.Index;
            txt_ad.Text = grd_tablo.Rows[secili_deger].Cells["AD"].Value.ToString();
            txt_soyad.Text = grd_tablo.Rows[secili_deger].Cells["SOYAD"].Value.ToString();
            txt_tel.Text = grd_tablo.Rows[secili_deger].Cells["TELEFON NO"].Value.ToString();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (string.Compare(txt_ad.Text, "") != 0 && string.Compare(txt_ad.Text, "") != 0 && string.Compare(txt_tel.Text, "") != 0)
            {
                da.SelectCommand.CommandText = "INSERT INTO TELEFON_REHBERI VALUES ('','" + txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_tel.Text + "')";
                ds.Clear();
                da.Fill(ds);
            }
            else
            {
                da.Update(ds.Tables[0]);
            }

            da.SelectCommand.CommandText = "select * from TELEFON_REHBERI";
            ds.Clear();
            da.Fill(ds);
            MessageBox.Show("Kayıt Başarılı");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap=MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz?", "Sil", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            { 
                string tmp_id = Convert.ToString(grd_tablo[0, grd_tablo.CurrentCell.RowIndex].Value);
                string sql_sil = "delete from TELEFON_REHBERI where ID='" + tmp_id + "'";
                OracleCommand sil = new OracleCommand(sql_sil,baglanti);
            
                if (sil.ExecuteNonQuery() == 1)
                {
                MessageBox.Show("Kayıt Silindi"); 
                }

                ds.Clear();
                da.Fill(ds);
            }

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap=MessageBox.Show("Kaydı Güncellemek İstediğinizden Eminmisiniz?", "Güncelle", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {

                if (string.Compare(txt_ad.Text, "") != 0 && string.Compare(txt_soyad.Text, "") != 0 && string.Compare(txt_tel.Text, "") != 0)
                {
                    da.SelectCommand.CommandText = "UPDATE TELEFON_REHBERI SET AD ='" + txt_ad.Text + "', SOYAD='" + txt_soyad.Text + "',\"TELEFON NO\"='" + txt_tel.Text + "'  WHERE  ID='" + Convert.ToString(grd_tablo.CurrentRow.Cells[0].Value) + "'";
                    ds.Clear();
                    da.Fill(ds);
                }
                else
                {
                    da.Update(ds.Tables[0]);
                }


                da.SelectCommand.CommandText = "select * from TELEFON_REHBERI";
                ds.Clear();
                da.Fill(ds);

                MessageBox.Show("Güncelleme Başarılı");

            }

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_tel.Clear();
            

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            String q = "select * from TELEFON_REHBERI where AD like '%" + txt_ad.Text + "%' AND SOYAD like '%" + txt_soyad.Text + "%' AND \"TELEFON NO\" like '%" + txt_tel.Text + "%'";
            

            da.SelectCommand.CommandText = q;
            ds.Clear();
            da.Fill(ds);

         
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            da.SelectCommand.CommandText = " Select * From TELEFON_REHBERI";
            ds.Clear();
            da.Fill(ds);
        }

    }
}
