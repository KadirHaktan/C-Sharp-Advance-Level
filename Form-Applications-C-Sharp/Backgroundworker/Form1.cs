using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgroundworker
{
    public partial class Form1 : Form
    {
        private long toplam = 0;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Topla();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(toplam.ToString());
        }

        private void Topla()
        {
            long toplam = 0;
            for (int i = 0; i < 100000; i++)
            {
                toplam += i;
                this.Text = i.ToString();
                backgroundWorker1.ReportProgress(i / 1000);
            }
            MessageBox.Show(toplam.ToString());
        }

        private void btnTopla_Click_1(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}