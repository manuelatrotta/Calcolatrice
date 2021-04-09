using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {

        public double n1 = 0;
        public double n2 = 0;
        public int operazione = 0;
        public bool condizione = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 9;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 9;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {   
            if(condizione == true)
            {
                richTextBox1.Text = "" + 1;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 6;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 6;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 7;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 7;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 2;
                condizione = false;
            }
            else
            {
                if (condizione == true)
                {
                    richTextBox1.Text = "" + 2;
                    condizione = false;
                }
                else
                {
                    richTextBox1.Text += 2;
                };
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 3;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 4;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 4;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 5;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 8;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 8;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" + 10;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += 10;
            }
        }

        private void button4_Click(object sender, EventArgs e) //add
        {
            if (n1 == 0)
            {  
                if(richTextBox1.Text == "")
                {
                    richTextBox1.Text = "0";
                }
                n1 = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text = Convert.ToString(n1);
                operazione = 1;
                condizione = true;
            }
            else
            {
                n2 = Convert.ToDouble(richTextBox1.Text);
                n1 += n2;
                richTextBox1.Text = Convert.ToString(n1);
                operazione = 1;
                condizione = true;

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operazione)
            {
                case 1:

                    n2 = Convert.ToDouble(richTextBox1.Text);
                    n1 += n2;
                    richTextBox1.Text = Convert.ToString(n1);
                    condizione = true;
                    //riporto a zero n1 e n2 per evitare che ai successivi click di = si abbia la somam 
                    n1 = 0;
                    n2 = 0;
                    break;

                case 2:
                    n2 = Convert.ToDouble(richTextBox1.Text);
                    n1 -= n2;
                    richTextBox1.Text = Convert.ToString(n1);
                    condizione = true;
                    //riporto a zero n1 e n2 per evitare che ai successivi click di = si abbia la somam 
                    n1 = 0;
                    n2 = 0;
                    break;

            }
        }

        private void button13_Click(object sender, EventArgs e) // button .
        {
            if (condizione == true)
            {
                richTextBox1.Text = "" ;
                condizione = false;
            }
            else
            {
                richTextBox1.Text += ".";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = "0";
                }
                n1 = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text = Convert.ToString(n1);
                operazione = 2;
                condizione = true;
            }
            else
            {
                n2 = Convert.ToDouble(richTextBox1.Text);
                n1 -= n2;
                richTextBox1.Text = Convert.ToString(n1);
                operazione = 2;
                condizione = true;

            }
        }
    }
}
