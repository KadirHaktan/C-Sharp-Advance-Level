using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIP_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
         txtStatus.Invoke((MethodInvoker)delegate()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("Dedin ki : {0}",e.MessageString));
            });
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            txtStatus.Text += "Server başlatılıyor...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
            server.Start(ip,Convert.ToInt32(txtPort.Text));
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
