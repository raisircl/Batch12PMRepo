using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        string txt="";
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
                            rtb.SaveFile(saveFileDialog1.FileName); 
                            //string filepath = saveFileDialog1.FileName;
                            //File.WriteAllText(filepath, rtb.Text);
                        }

                    }
                }
                rtb.Text = "";
            }
            else if(tag==2)
            {
                openFileDialog1.Filter= "All Text Files(*.txt)|*.txt|All Rich Text Files(*.rtf)|*.rtf";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtb.LoadFile(openFileDialog1.FileName);
                }
            }
            else if (tag ==3)
            {
                saveFileDialog1.Filter = "All Text Files(*.txt)|*.txt|All Rich Text Files(*.rtf)|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtb.SaveFile(saveFileDialog1.FileName);
                }
            }
            else if (tag == 4)
            {
                saveFileDialog1.Filter = "All Text Files(*.txt)|*.txt|All Rich Text Files(*.rtf)|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtb.SaveFile(saveFileDialog1.FileName);
                }
            }
            else if(tag==5)
            {
                PrinterSettings printerSettings = new PrinterSettings();
                printerSettings.Copies = 1;
                PageSettings pageSettings = new PageSettings();
                pageSettings.PrinterSettings = printerSettings;
                pageSetupDialog1.PageSettings=pageSettings;
                pageSetupDialog1.ShowDialog();
                
            }
            else if(tag == 6)
            {
                printDialog1.ShowDialog();
            }
            else if(tag == 7){
                this.Close();
                
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = rtb.SelectedText;
            rtb.SelectedText = "";
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = rtb.SelectedText;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectedText = txt;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Redo();
        }
    }
}
