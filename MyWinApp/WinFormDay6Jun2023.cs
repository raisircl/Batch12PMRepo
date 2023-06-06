using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MyWinApp
{
    public partial class WinFormDay6Jun2023 : Form
    {
        public WinFormDay6Jun2023()
        {
            InitializeComponent();
        }
        TreeNode mypctnode;
      
        private void WinFormDay6Jun2023_Load(object sender, EventArgs e)
        {
            loadDrives();
        }
        void loadDrives()
        {
            mypctnode = new TreeNode("My PC");
            mypctnode.ImageIndex = 4;
            mypctnode.SelectedImageIndex = 4;
            tv1.Nodes.Add(mypctnode);   

            foreach(var drive in Directory.GetLogicalDrives())
            {
              
                TreeNode tnode = new TreeNode(drive);
                tnode.ImageIndex = 0;
                tnode.SelectedImageIndex = 0;
                mypctnode.Nodes.Add(tnode);
                foreach(var dir in Directory.GetDirectories(drive))
                {
                    
                    DirectoryInfo di=new DirectoryInfo(dir);
                    TreeNode tnodefolder = new TreeNode(di.Name);
                    tnodefolder.ImageIndex = 1;
                    tnodefolder.SelectedImageIndex = 2;
                    tnodefolder.Tag = di.FullName;

                    tnode.Nodes.Add(tnodefolder);
                    
                }
            }
        }
    }
}
