using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool keyup = false;
        bool keyleft = false;



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                keyup = true;
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                keyleft = true;
            }

            if (keyleft && keyup)
            {
                MessageBox.Show("12");
            }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyup = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyleft = false;
            }
        }
    }
}
