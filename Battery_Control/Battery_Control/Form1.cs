using System;
using System.Windows.Forms;
using System.Media;

namespace Battery_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Batarya batarya = new Batarya();
            batarya.Percent = Convert.ToByte(SystemInformation.PowerStatus.BatteryLifePercent * 100);
            batarya.Remaining = Convert.ToByte(SystemInformation.PowerStatus.BatteryLifeRemaining / 60);
            progressBar1.Value = Convert.ToInt32(batarya.Percent.ToString());
            Kalan_Sarj.Text= "Kalan Şarjınız : " + batarya.Percent.ToString();
            if (batarya.Percent == 100)
            {
                Kalan_Sarj.Text = "Batarya Tam Dolu";

            }
            else if ((batarya.Percent <= 96) && (batarya.Percent >= 50))
            {
                Kalan_Sarj.Text = "Şarjınız İyi Durumda";
                SoundPlayer player = new SoundPlayer();
                string path = "C:\\windows\\media\\start.wav"; // Çalmasini istediginiz ses dosyasinin yolu
                player.SoundLocation = path;
                player.Play();
            }
            else
            {
                Kalan_Sarj.Text = "Şarjınız Bitmek üzere";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Batarya batarya = new Batarya();
            batarya.Percent = Convert.ToByte(SystemInformation.PowerStatus.BatteryLifePercent * 100);
            batarya.Remaining = Convert.ToByte(SystemInformation.PowerStatus.BatteryLifeRemaining / 60);
            progressBar1.Value = Convert.ToInt32(batarya.Percent.ToString());
            Kalan_Sarj.Text = "Kalan Şarjınız : " + batarya.Percent.ToString();
            if (batarya.Percent == 100)
            {
                Kalan_Sarj.Text = "Batarya Tam Dolu";

            }
            else if ((batarya.Percent <= 96) && (batarya.Percent >= 50))
            {
                Kalan_Sarj.Text = "Şarjınız İyi Durumda";
                SoundPlayer player = new SoundPlayer();
                string path = "C:\\windows\\media\\start.wav"; // Çalmasini istediginiz ses dosyasinin yolu
                player.SoundLocation = path;
                player.Play();
            }
            else
            {
                Kalan_Sarj.Text = "Şarjınız Bitmek üzere";
            }
        }
    }
}
