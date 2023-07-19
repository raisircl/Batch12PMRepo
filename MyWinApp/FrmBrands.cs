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
        void loadGrid(int bid=0)
        {
            ds.Tables.Clear();

            //comm.CommandText = "select * from production.brands";
            comm.CommandText = "sp_fetchbrands";
            if(bid !=0) {
                comm.Parameters.AddWithValue("@bid", bid);
            }
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "brands");
            dgvBrand.DataSource = ds.Tables["brands"];
            comm.Parameters.Clear();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                loadGrid(Convert.ToInt32(textBox1.Text));
            }
            else
            {
                loadGrid(); 
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt32(e.KeyChar);
            if((ascii>=48 && ascii<=57) || ascii==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.Length>0)
            {
                loadGrid(textBox2.Text);
            }
            else
            {
                loadGrid("");
            }
        }

        void loadGrid(string bname)
        {
            ds.Tables.Clear();

            //comm.CommandText = "select * from production.brands";
            comm.CommandText = "sp_brands_byname";
            //if (bname != "")
            //{
            //    comm.CommandText = "select * from production.brands where brand_name like '%' + @bname +'%'";
            //    comm.Parameters.AddWithValue("@bname", bname);
            //}
            //else
            //{
            //    comm.CommandText = "select * from production.brands";
            //}
            comm.Parameters.AddWithValue("@bname", bname);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "brands");
            dgvBrand.DataSource = ds.Tables["brands"];
            comm.Parameters.Clear();
        }
    }
}
