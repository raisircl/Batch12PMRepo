using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class FrmClass2June2023 : Form
    {
        public FrmClass2June2023()
        {
            InitializeComponent();
        }
        int x;

        private void btnMove_Click(object sender, EventArgs e)
        {
            x = lbSource.Items.Count;
            pb1.Maximum=x;
            pb1.Minimum = 0;
            timer1.Enabled=true;
            timer1.Start(); 
        }

        private void FrmClass2June2023_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2000; i++)
            {
                lbSource.Items.Add($"Item{i}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbSource.Items.Count > 0)
            {
                
                lbTarget.Items.Add(lbSource.Items[0]);
                lbSource.Items.RemoveAt(0);
                pb1.Value++;
                int p = pb1.Value * 100/x;
             
                label1.Text = $"{p}%";
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
