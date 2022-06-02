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


namespace Tutorial_Symphony
{
    public partial class FormProducts : Form
    {
        public FormProducts()
            
        {
            InitializeComponent();
            DBConnects dbcn = new DBConnects();
            SqlConnection dbc = new SqlConnection();
            dbc = new SqlConnection(dbcn.DBConnection1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnects dbcn = new DBConnects();
            SqlConnection dbc = new SqlConnection();
            dbc = new SqlConnection(dbcn.DBConnection1());
            dbc.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Product", dbc);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dgproducts.DataSource = dtbl;
            dbc.Close();
        }

        private void dgproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            DBConnects dbcn = new DBConnects();
            SqlConnection dbc = new SqlConnection();
            dbc = new SqlConnection(dbcn.DBConnection1());
            dbc.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Product", dbc);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dgproducts.DataSource = dtbl;
            dbc.Close();
        }
    }
}
