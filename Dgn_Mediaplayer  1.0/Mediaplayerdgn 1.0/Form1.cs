using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Mediaplayerdgn_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.ShowDialog();
            WMPLib.IWMPMedia media = axWindowsMediaPlayer1.newMedia(ac.FileName);
            axWindowsMediaPlayer1.currentPlaylist.clear();
            axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            listBox1.Items.Add(axWindowsMediaPlayer1.currentMedia.name);
            listBox1.Items.Add(axWindowsMediaPlayer1.currentMedia.sourceURL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader liste = File.OpenText(@"C:\PlayList.txt");
                listBox1.Items.Clear();
                while (liste.EndOfStream == false)
                {
                    listBox1.Items.Add(liste.ReadLine());
                    listBox1.Items.Add(liste.ReadLine());
                }
                liste.Close();
            }
            catch
            {
                MessageBox.Show("Kayıtlı Parça Listesi Yok");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter yaz = new StreamWriter(@"C:\PlayList.txt");
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    yaz.WriteLine(listBox1.Items[i].ToString());
                    yaz.WriteLine(listBox1.Items[i].ToString());
                }
                yaz.Close();
                MessageBox.Show("Play List Kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
