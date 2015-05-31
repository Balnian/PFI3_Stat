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

            RDB_F1.Checked = RDB_F2.Checked = RDB_F3.Checked = RDB_F4.Checked = RDB_F5.Checked = false;
        }
    }
}
