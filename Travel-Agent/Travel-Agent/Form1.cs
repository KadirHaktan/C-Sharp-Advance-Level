using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            int araKoltuk = 3;
            int KoridorIcinBosHazirlananKoltuklarHaric = 0;
            int bosHazirlananlarIcinEklenecekler = 0;

            for (int i=1; i<= 54 + bosHazirlananlarIcinEklenecekler; i++)
            {
                Button btn = new Button();
                btn.Width = 37;
                btn.Margin = new Padding(all:1);
                if(araKoltuk == i)
                {
                    araKoltuk += 5;
                    btn.Height = 0;
                    bosHazirlananlarIcinEklenecekler++;
                }
                else if(araKoltuk !=i)
                {
                    KoridorIcinBosHazirlananKoltuklarHaric++;
                    btn.Height = 37;
                    btn.Text = KoridorIcinBosHazirlananKoltuklarHaric.ToString();
                    btn.Tag = KoridorIcinBosHazirlananKoltuklarHaric;

                }

                
                btn.Click += btn_Click;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                flwPanel.Controls.Add(btn);
            
            }
            grbKisisel.Enabled = false;
            Label lblKapi = new Label();
            lblKapi.Width = 77;
            lblKapi.Height = 37;
            lblKapi.BorderStyle = BorderStyle.FixedSingle;
            lblKapi.Margin = new Padding(39,1,0,0);
            lblKapi.BackColor = Color.Cornsilk;
            lblKapi.Text = "KAPI";
            lblKapi.TextAlign = ContentAlignment.MiddleCenter;
            flwPanel.Controls.Add(lblKapi);
            radioBay.Checked = true;
            txtKoltuk.Enabled = false;
        }

        Button secilenButonuHafizadaTut;

        void btn_Click(object sender, EventArgs e)
        {
            Button myBtn = sender as Button;
            grbKisisel.Enabled = true;
            txtKoltuk.Text = myBtn.Tag.ToString();
            secilenButonuHafizadaTut = myBtn;
        }

        String Boslar;
      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (Control txt in grbKisisel.Controls)
            {
                if (txt is TextBox)
                {
                    TextBox mytxt = txt as TextBox;
                    if (string.IsNullOrWhiteSpace(mytxt.Text)) Boslar = mytxt.Name + "-";
                    if (!string.IsNullOrEmpty(Boslar))
                    {
                        MessageBox.Show(Boslar, "Şu nesneleri Boş Bırakmamalısınız!", MessageBoxButtons.OK);
                        mytxt.Select();
                        return;
                    }
                }
            }
            string cinsiyet = radioBay.Checked ? radioBay.Text : radioBayan.Text;
            string veriler = txtKoltuk.Text + " no'lu Koltuk " + txtAd.Text + txtSoyad.Text + " " + cinsiyet + " Tel No : " + txtTelNo.Text;

            listBox1.Items.Add(veriler);

            cinsiyet = radioBay.Checked ? "C:\\Users\\Dogan\\Documents\\Visual Studio 2017\\Projects\\Travel-Agent\\Travel-Agent\\images\\man.png" : "C:\\Users\\Dogan\\Documents\\Visual Studio 2017\\Projects\\Travel-Agent\\Travel-Agent\\images\\woman.png";
            secilenButonuHafizadaTut.BackgroundImage = Image.FromFile(cinsiyet);
            secilenButonuHafizadaTut.Enabled = false;
            secilenButonuHafizadaTut.BackColor = radioBay.Checked ? Color.Azure : Color.LightPink;
            grbKisisel.Enabled = false;
            MessageBox.Show("Kayıt Başarılı");



        }
    }
}
