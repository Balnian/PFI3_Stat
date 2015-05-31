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
            TXB_A.Clear();
            TXB_B.Clear();
        }

        private void BTN_Calculer_Click(object sender, EventArgs e)
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
        }

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
    }
}
