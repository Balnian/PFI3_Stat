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
            //Dont mind me just a test
            TXB_A.Clear();
            TXB_B.Clear();

            RDB_F1.Checked = RDB_F2.Checked = RDB_F3.Checked = RDB_F4.Checked = RDB_F5.Checked = false;

            for (int i = 0; i < 1000; i++)
            {
                g = PBX_Drawing.CreateGraphics();
                g.DrawEllipse(pen1, i, (int)(Math.Cos(i)+3), 3, 3);
                g.Dispose();
            }
        }

        //générateur de position
        private double Generateur(double min,double max)
        {
            Random random = new Random();
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
                    return y <= 3*Math.Pow((double)(x-7)/5,5)-5*Math.Pow((double)(x-7)/5,3)+3;
                    break;
                case 2:
                    return y <= (double)(-1 / 3) * Math.Pow(x - 6, 2) + 12;
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

        }
    }
}
