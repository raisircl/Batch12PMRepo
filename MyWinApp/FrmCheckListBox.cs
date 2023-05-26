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
    public partial class FrmCheckListBox : Form
    {
        public FrmCheckListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          foreach(var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
