using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MediaPlayer2
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string[] files = System.IO.Directory.GetFiles(s[0]);
            foreach (string t in files)
            {
                listBox1.Items.Add(System.IO.Path.GetFileName(t)); 
                listBox2.Items.Add(System.IO.Path.GetFullPath(t));
            }
        }

        private void ac_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.ShowDialog();
            WMPLib.IWMPMedia media = axWindowsMediaPlayer1.newMedia(ac.FileName);
            axWindowsMediaPlayer1.currentPlaylist.clear();
            axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
            axWindowsMediaPlayer1.Ctlcontrols.play() ;
            listBox1.Items.Add(axWindowsMediaPlayer1.currentMedia.name);
            listBox2.Items.Add(axWindowsMediaPlayer1.currentMedia.sourceURL);
        }

        private void cal_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void dur_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += timer1_Tick;
            t.Start();
        }
        
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.status != "")
            {
                label1.Text ="Parça Adı         "+ axWindowsMediaPlayer1.currentMedia.name;
                label2.Text ="Parça Süresi    "+ axWindowsMediaPlayer1.currentMedia.durationString;
                label3.Text ="Geçen Süre      "+ axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            }
        }

        private void liste_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter yaz = new StreamWriter(@"C:\PlayList.txt");
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    yaz.WriteLine(listBox1.Items[i].ToString());
                    yaz.WriteLine(listBox2.Items[i].ToString());
                }
                yaz.Close();
                MessageBox.Show("Play List Kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void liste_ac_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader liste = File.OpenText(@"C:\PlayList.txt");
                listBox1.Items.Clear();
                while (liste.EndOfStream == false)
                {
                    listBox1.Items.Add(liste.ReadLine());
                    listBox2.Items.Add(liste.ReadLine());
                }
                liste.Close();
            }
            catch 
            {
                MessageBox.Show("Kayıtlı Parça Listesi Yok");
            }
        }
   
    }
}
