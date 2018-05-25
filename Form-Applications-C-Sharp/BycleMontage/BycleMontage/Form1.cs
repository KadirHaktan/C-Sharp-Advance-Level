using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BycleMontage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFrenTipi.Items.AddRange(Enum.GetNames(typeof(FrenTipi)));
            comboBoxFrenTipi.SelectedIndex = 0;
            comboBoxKadroTipi.Items.AddRange(Enum.GetNames(typeof(KadroTipi)));
            comboBoxKadroTipi.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bycle bcycle = new Bycle
            {
                Fren = (FrenTipi)comboBoxFrenTipi.SelectedIndex,
                Kadro = (KadroTipi)comboBoxKadroTipi.SelectedIndex,

                _ModelYili = dateTimePicker1.Value.Year

            };
            txtYasi.Text = bcycle.Yasi.ToString();
            MessageBox.Show(bcycle.ToString());
        }
    }
}
