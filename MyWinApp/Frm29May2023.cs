using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class Frm29May2023 : Form
    {
        public Frm29May2023()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            if(chkPlaying.Checked && chkReading.Checked)
            {
                MessageBox.Show("Excelent");
            }
            else if(chkReading.Checked)
            {
                MessageBox.Show("Very Good");
            }
            else if(chkPlaying.Checked) 
            {
                MessageBox.Show("Good");
            }
            else
            {
                MessageBox.Show("Please select choice");
            }
        }

        private void chkSameAddress_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSameAddress.Checked)
            {
                txtPosHNO.Text = txtPerHno.Text;
                txtPosCityVPO.Text = txtPerCityVPO.Text;
                txtPosAddress.Text = txtPerAddress.Text;
            }
            else
            {
                txtPosHNO.Text = "";
                txtPosCityVPO.Text = "";
                txtPosAddress.Text = "";
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(100, "Demo", "Demo Text", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome...");
        }
    }
}
