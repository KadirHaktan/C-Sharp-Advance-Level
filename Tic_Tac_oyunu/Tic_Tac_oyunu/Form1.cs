using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_oyunu
{
    public partial class Form1 : Form
    {
        bool turn = true; //  true =x false=y
        int turn_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkindaMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ebubekir Doğan tarafından tasarlanmıştır...", "Tic Tac Toe");
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "0";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool kazanan = false;

            //dikey
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                kazanan = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                kazanan = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                kazanan = true;

            //yatay
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                kazanan = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                kazanan = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                kazanan = true;



            //yatay
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                kazanan = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                kazanan = true;
            

            if (kazanan)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = "0";
                    osayisi.Text = (Int32.Parse(osayisi.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    xsayisi.Text = (Int32.Parse(xsayisi.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " kazandı.!", "Yay!");

            }//end if
            else
             {
                if (turn_count == 9)
                {
                    kayipsayisi.Text = (Int32.Parse(kayipsayisi.Text) + 1).ToString();
                    MessageBox.Show("Kazanan Olmadı :) !", "Yay!");
                }
            }
         }//end checkForWinner


        private void disableButtons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                
                    }//endforeach

            }//endTryCath
            catch {}
        }

        private void yeniOyuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
           

                foreach (Control c in Controls)
                 {
                    try
                     {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                     }
                catch { }
            }//endforeach
            
        }//endTryCath
            
  

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
                { 
                if (turn)
                   b.Text = "X";
                else
                   b.Text = "0";
                 }//end if
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }//end if
        }
    }
 
}
 
