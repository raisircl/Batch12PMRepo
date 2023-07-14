using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace MyWinApp
{
    public partial class FrmDept : Form
    {
        public FrmDept()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["conn"]);
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet(); 
        private void FrmDept_Load(object sender, EventArgs e)
        {
            //conn.ConnectionString= ConfigurationSettings.AppSettings["conn"];
            //conn.Open();   
            //  if(conn.State==ConnectionState.Open)
            //   {
            //       MessageBox.Show("connection establish successfully");
            //   }
            //  conn.Close();    
            loadGrid();
        }
        void loadGrid()
        {
            comm.CommandText = "select * from production.products";
            comm.Connection = conn; 
            da.SelectCommand = comm;
            da.Fill(ds, "products");
            dataGridView1.DataSource = ds.Tables["products"];

        }
    }
}
