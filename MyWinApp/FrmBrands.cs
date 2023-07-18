using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class FrmBrands : Form
    {
        public FrmBrands()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Common.connectionString);
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        void loadGrid()
        {
            ds.Tables.Clear();

            comm.CommandText = "select * from production.brands";
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "brands");
            dgvBrand.DataSource = ds.Tables["brands"];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            comm.CommandText = "insert into production.brands values(@bname)";
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@bname", txtBName.Text);
            comm.CommandType=CommandType.Text;
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            loadGrid(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            comm.CommandText = "update production.brands set brand_name=@bname where brand_id=@id";
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@id", txtBId.Text);
            comm.Parameters.AddWithValue("@bname", txtBName.Text);
            comm.CommandType = CommandType.Text;
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            loadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            comm.CommandText = "delete from production.brands where brand_id=@id";
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@id", txtBId.Text);
           
            comm.CommandType = CommandType.Text;
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            loadGrid();
        }
    }
}
