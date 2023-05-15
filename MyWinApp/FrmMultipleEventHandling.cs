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
    public partial class FrmMultipleEventHandling : Form
    {
        public FrmMultipleEventHandling()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {button1.Text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {button2.Text}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {button3.Text}");
        }

        private void btnMyClick(object sender, EventArgs e)
        {
            //sender keep the refrence which button is click. it is ref of object class
            //object class is parent class of each class in .net framework
            //its rule in oop reference of parent class can point to child class
            Button btn=(Button)sender;

            MessageBox.Show($"Hello {btn.Text}");
        }

        private void btnDigitClick(object sender, EventArgs e)
        {
            int x = 10;
            x += 10;

            Button btn = (Button)sender;

            textBox1.Text = textBox1.Text+btn.Text;

        }
    }
}
