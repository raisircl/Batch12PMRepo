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
    public partial class FrmDP : Form
    {
        public FrmDP()
        {
            InitializeComponent();
        }

        private void MyCLick(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            MessageBox.Show(btn.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSum frmSum = new FrmSum();
            frmSum.Show();    

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text=dateTimePicker1.Value.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}
