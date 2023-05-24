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
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(txtCourseName.Text);

        }

        private void FrmComboBox_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex= 0; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex>-1)
            txtCourseName.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();

        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            comboBox1.Items[comboBox1.SelectedIndex]= txtCourseName.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }
    }
}
