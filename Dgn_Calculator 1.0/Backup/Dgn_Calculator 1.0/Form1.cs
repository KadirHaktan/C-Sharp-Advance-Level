using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dgn_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac; //on/off butonu için
        string islem ; // işlemler için case için
        int  x ;

        
        private void button22_Click(object sender, EventArgs e)
        {
            sayac = sayac + 1;
            button22.Text = "KAPAT";
            if (sayac == 1)
            {
                label1.Visible = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;

                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                textBox1.Enabled = true;
                button23.Enabled = true;
                button24.Enabled = true;
            }

            else
            {
                button22.Text = "KAPAT";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;

                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                textBox1.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                textBox1.Text = " ";
                label1.Visible = true;
                
              }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;

            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            textBox1.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 00;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x);
            islem = "+";
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x);
            islem = "-";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x);
            islem = "*";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x);
            islem = "/";
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
             
            switch (islem)
            {
                case "+"  :  textBox1.Text = Convert.ToString(x + (int.Parse(textBox1.Text))); break;
                case "-"  :  textBox1.Text = Convert.ToString(x - (int.Parse(textBox1.Text))); break;
                case "/"  :  textBox1.Text = Convert.ToString(x / (int.Parse(textBox1.Text))); break;
                case "*"  :  textBox1.Text = Convert.ToString(x * (int.Parse(textBox1.Text))); break;
                case "sqrt": textBox1.Text = Convert.ToString(Math.Sqrt(int.Parse(textBox1.Text))); break;
                case "%"  :  textBox1.Text = Convert.ToString(Math.Pow(x,(int.Parse(textBox1.Text)))); break;
                case "tan":  textBox1.Text = Convert.ToString(Math.Tan(int.Parse(textBox1.Text))); break;
                case "cos":  textBox1.Text = Convert.ToString(Math.Cos(int.Parse(textBox1.Text))); break;
                

            }
            
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x);
            islem = "%";
            textBox1.Text = "";
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x);
            islem = "tan";

            textBox1.Text = "";
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x);
            islem = "cos";

            textBox1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = textBox1.Text;
            textBox1.Text = "";
        
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            label2.Text = Convert.ToString(x);
            islem = "sqrt";
            textBox1.Text = "";
        
        }
    }
}
