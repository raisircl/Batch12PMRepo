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
    public partial class Frm13June2023 : Form
    {
        public Frm13June2023()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            webBrowser1.Url=new Uri(txturl.Text);
            
        }
    }
}
