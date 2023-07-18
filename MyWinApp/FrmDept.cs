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
        //SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=BikeStoreBatch4PM;Persist Security Info=True;User ID=sa;Password=rai11**");
        SqlConnection conn =new SqlConnection(Common.connectionString);
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
            ds.Tables.Clear();

            comm.CommandText = "select * from production.brands";
            comm.Connection = conn; 
            da.SelectCommand = comm;
            da.Fill(ds, "brands");
            dataGridView1.DataSource = ds.Tables["brands"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "brands");
            MessageBox.Show("data saved");
            loadGrid(); 
        }
    }
}
