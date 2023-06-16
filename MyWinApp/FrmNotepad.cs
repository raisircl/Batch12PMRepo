using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class FrmNotepad : Form
    {
        public FrmNotepad()
        {
            InitializeComponent();
        }

        private void mi_click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi=(ToolStripMenuItem)sender; 
            int tag=Convert.ToInt32(mi.Tag);    
            if(tag==1)
            {
                if(rtb.Text.Length > 0)
                {
                    
                   DialogResult dr= MessageBox.Show("Do you want to save the changes", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if(dr==DialogResult.Yes) {
                        saveFileDialog1.Filter = "All Text Files(*.txt)|*.txt|All Rich Text Files(*.rtf)|*.rtf";
                        if(saveFileDialog1.ShowDialog()== DialogResult.OK)
                        {
                            string filepath = saveFileDialog1.FileName;
                            File.WriteAllText(filepath, rtb.Text);
                        }

                    }
                }
                rtb.Text = "";
            }
            else if(tag==2)
            {
                openFileDialog1.Filter= "All Text Files(*.txt)|*.txt|All Rich Text Files(*.rtf)|*.rtf";

            }
            else if (tag ==3)
            {
                saveFileDialog1.Filter = "All Text Files(*.txt)|*.txt|All Rich Text Files(*.rtf)|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filepath = saveFileDialog1.FileName;
                    File.WriteAllText(filepath, rtb.Text);
                }
            }
        }
    }
}
