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
    public partial class FrmSum : Form
    {
        public FrmSum()
        {
            InitializeComponent();
        }
        int n1, n2, r;
        private void btnSum_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(txtn1.Text);
            n2 = Convert.ToInt32(txtn2.Text);
            r = n1 + n2;
            lblResult.Text = Convert.ToString(r);
        }

    }
}
