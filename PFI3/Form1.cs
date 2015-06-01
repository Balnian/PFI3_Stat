using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFI3
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        private System.Drawing.Graphics g;
        Pen pen1 = new Pen(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }

        private void RDB_F1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = 
            label2.Enabled = 
            TXB_A.Enabled = 
            TXB_B.Enabled = 
            BTN_Calculer.Enabled = 
            (RDB_F1.Checked ||
             RDB_F2.Checked ||
             RDB_F3.Checked ||
             RDB_F4.Checked ||
             RDB_F5.Checked);
        }

        private void RDB_F2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled =
            label2.Enabled =
            TXB_A.Enabled =
            TXB_B.Enabled =
            BTN_Calculer.Enabled =
            (RDB_F1.Checked ||
             RDB_F2.Checked ||
             RDB_F3.Checked ||
             RDB_F4.Checked ||
             RDB_F5.Checked);
        }

        private void RDB_F3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled =
            label2.Enabled =
            TXB_A.Enabled =
            TXB_B.Enabled =
            BTN_Calculer.Enabled =
            (RDB_F1.Checked ||
             RDB_F2.Checked ||
             RDB_F3.Checked ||
             RDB_F4.Checked ||
             RDB_F5.Checked);
        }

        private void RDB_F4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled =
            label2.Enabled =
            TXB_A.Enabled =
            TXB_B.Enabled =
            BTN_Calculer.Enabled =
            (RDB_F1.Checked ||
             RDB_F2.Checked ||
             RDB_F3.Checked ||
             RDB_F4.Checked ||
             RDB_F5.Checked);
        }

        private void RDB_F5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled =
            label2.Enabled =
            TXB_A.Enabled =
            TXB_B.Enabled =
            BTN_Calculer.Enabled =
            (RDB_F1.Checked ||
             RDB_F2.Checked ||
             RDB_F3.Checked ||
             RDB_F4.Checked ||
             RDB_F5.Checked);
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TXB_A.Clear();
            TXB_B.Clear();
        }

     /*   private void BTN_Calculer_Click(object sender, EventArgs e)
        {
            if (TXB_A.Text != "" && TXB_B.Text != "")
            {
                if (RDB_F1.Checked)
                {

                }
                else if (RDB_F2.Checked)
                {

                }
                else if (RDB_F3.Checked)
                {

                }
                else if (RDB_F4.Checked)
                {

                }
                else if (RDB_F5.Checked)
                {

                }
            }
            else
            {
                if(TXB_A.Text == "")
                {
                    TXB_A.ForeColor = Color.IndianRed;
                    label1.ForeColor = Color.IndianRed;
                    TXB_A.Text = "Veuillez entrer une valeur";
                }
                if (TXB_B.Text == "")
                {
                    TXB_B.ForeColor = Color.IndianRed;
                    label2.ForeColor = Color.IndianRed;
                    TXB_B.Text = "Veuillez entrer une valeur";
                }
            }
        }*/

        private void TXB_A_MouseDown(object sender, MouseEventArgs e)
        {
            if(TXB_A.Text == "Veuillez entrer une valeur")
            {
                TXB_A.Text = "";
                label1.ForeColor = Color.Black;
                TXB_A.ForeColor = Color.Black;
            }
        }

        private void TXB_B_MouseDown(object sender, MouseEventArgs e)
        {
            if (TXB_B.Text == "Veuillez entrer une valeur")
            {
                TXB_B.Text = "";
                label2.ForeColor = Color.Black;
                TXB_B.ForeColor = Color.Black;
            }
        }

        private void TXB_A_Leave(object sender, EventArgs e)
        {
            if (TXB_A.Text == "")
            {
                TXB_A.ForeColor = Color.IndianRed;
                label1.ForeColor = Color.IndianRed;
                TXB_A.Text = "Veuillez entrer une valeur";
            }
        }

        private void TXB_B_Leave(object sender, EventArgs e)
        {
            if (TXB_B.Text == "")
            {
                TXB_B.ForeColor = Color.IndianRed;
                label2.ForeColor = Color.IndianRed;
                TXB_B.Text = "Veuillez entrer une valeur";
            }
        }

        //générateur de position
        private double Generateur(double min,double max)
        {
            
            return random.Next((int)(min*100),(int)(max*100+1))/100;
        }
        //vérifie si les coordonné sont sous la courbe selon l'équation
        // 0: f1(x)
        // 1: f2(x)
        // 2: f3(x)
        // 3: f4(x)
        // 4: f5(x)
        private bool estSousLaCourbe(int numEquation, double x, double y)
        {
            double carry = 0;
            switch(numEquation)
            {
                case 0:
                    carry = Math.Pow(x,2)-16*x+63;
                    
                    return y<=-Math.Pow(carry,(double)1/3)+4;

                    break;
                case 1:
                    carry = (double)(x-7)/5;
                    return y <= (3 * Math.Pow(carry, 5)) - (5 * Math.Pow(carry, 3)) + 3;
                    break;
                case 2:
                    return y <= ((double)-1 / 3) * Math.Pow(x - 6, 2) + 12;
                    break;
                case 3:
                    return y <= x + Math.Sin(x);
                    break;
                case 4:
                    return y <= Math.Cos(x) + 3;
                    break;
                default:
                    return false;
                    break;
            }
        }

        private void BTN_Calculer_Click(object sender, EventArgs e)
        {
            int numFct = 0;
            int yMax=0;
            if (RDB_F1.Checked)
            {
                numFct = 0;
                yMax=5;
            }                
            else if (RDB_F2.Checked)
            {
                numFct = 1;
                yMax=5;
            }               
            else if (RDB_F3.Checked)
            {
                numFct = 2;
                yMax=12;
            }                
            else if (RDB_F4.Checked)
            {
                numFct = 3;
                yMax=10;
            }               
            else if (RDB_F5.Checked)
            {
                numFct = 4;
                yMax=4;
            }
                

            int compteur = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (estSousLaCourbe(numFct,Generateur((double)NUD_A.Value,(double)NUD_B.Value),Generateur(0,yMax)))
                {
                 compteur++;   
                }
            }
            double air = (double)(NUD_B.Value-NUD_A.Value)*yMax;
            MessageBox.Show((((double)compteur/10000)*air).ToString());
            
        }
    }
}
