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
    public partial class FrmListAndCombo : Form
    {
        public FrmListAndCombo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!listBox1.Items.Contains(textBox1.Text))
            listBox1.Items.Add(textBox1.Text);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                label1.Text=listBox1.SelectedItem.ToString();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // remove selected
            if(listBox1.SelectedIndex>-1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecte item first to remove");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //display all
            label1.Text = "";
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                label1.Text += listBox1.Items[i].ToString()+"\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //display selected  items
            label1.Text = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                label1.Text += listBox1.SelectedItems[i].ToString() + "\n";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // remove all
            //listBox1.Items.Clear();
            //or
            int x = listBox1.Items.Count;
            for(int i = 0;i<x;i++)
            {
                listBox1.Items.RemoveAt(0);

            }
        }
    }
}
