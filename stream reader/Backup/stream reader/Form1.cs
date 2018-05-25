using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace stream_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter yazbakalým = File.AppendText("C:\\bizim\\bizim.txt");
            yazbakalým.WriteLine(textBox1.Text);
            yazbakalým.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader okubunu = new StreamReader("C:\\bizim\\bizim.txt");
            richTextBox1.Text = okubunu.ReadLine();
            okubunu.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader okubunu = new StreamReader("C:\\bizim\\bizim.txt");
            richTextBox1.Text = okubunu.ReadToEnd();
            okubunu.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader okubunu = new StreamReader("C:\\bizim\\bizim.txt");
            String metin = okubunu.ReadLine();
            while (metin != null)
            {
                richTextBox1.Text += metin + "\n";
                metin = okubunu.ReadLine();

            }

            okubunu.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bizim=textBox1.Text;
            int sayac=0;
            StreamReader okubunu = new StreamReader("C:\\bizim\\bizim.txt");
            String metin = okubunu.ReadLine();
            while (metin != null)
            {
                if(metin==bizim)
                {
                    sayac++;
                  metin = okubunu.ReadLine();
                }
               

            }

            okubunu.Close();
            if (sayac == 0)
            {

                StreamWriter yazbakalým = File.AppendText("C:\\bizim\\bizim.txt");
                yazbakalým.WriteLine(textBox1.Text);
                yazbakalým.Close();
            }

        }
    }
}