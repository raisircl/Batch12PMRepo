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
    public partial class FrmDataset : Form
    {
        public FrmDataset()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet(); // dataset is collection of data tables 
        
        DataTable dt = new DataTable("dtdept");  // datatable collection data columns and datarows
        
        DataColumn dc1 = new DataColumn("DNo");
        DataColumn dc2 = new DataColumn("DName");
        DataColumn dc3 = new DataColumn("Loc");
        
        int si = -1; // si mean selected index of grid

        private void FrmDataset_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);

            ds.Tables.Add(dt);

            dgvDept.DataSource = ds.Tables["dtdept"]; // ds.Tables[0];
            reset();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDno.Text != "" && txtDName.Text != "")
            {
                DataRow dr = dt.NewRow();
                dr["DNo"] = txtDno.Text;
                dr["DName"] = txtDName.Text;
                dr["Loc"] = txtLoc.Text;
                ds.Tables["dtdept"].Rows.Add(dr);
                reset();
            }
            else
            {
                MessageBox.Show("Fill required field");
            }
        }
        void reset()
        {
            txtDno.Text = "";
            txtDName.Text = "";
            txtLoc.Text = "";
            txtDno.Focus();
            btnUpdate.TabStop=false;
            btnSave.TabStop = true;
            btnSave.BringToFront(); 
            btnDelete.Visible = false;  
            si = -1;
        }

        private void dgvDept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            si= e.RowIndex;
            txtDno.Text = dgvDept.Rows[si].Cells["DNo"].Value.ToString();
            txtDName.Text = dgvDept.Rows[si].Cells["DName"].Value.ToString();
            txtLoc.Text = dgvDept.Rows[si].Cells["Loc"].Value.ToString();
            btnUpdate.BringToFront();
            btnDelete.Visible = true;
            btnSave.TabStop = false;
            btnUpdate.TabStop=true; 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(si>-1)
            {
                ds.Tables["dtdept"].Rows[si]["DNo"] = txtDno.Text;
                ds.Tables["dtdept"].Rows[si]["DName"] = txtDName.Text;
                ds.Tables["dtdept"].Rows[si]["Loc"] = txtLoc.Text;
                reset();
            }
            else
            {
                MessageBox.Show("Plese select a record");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(si>-1)
            {
                ds.Tables["dtdept"].Rows[si].Delete();
                reset();
            }
        }
    }
}
