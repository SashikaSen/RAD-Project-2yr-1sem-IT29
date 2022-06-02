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
    public partial class FormBilling : Form
    {
        public FormBilling()
        {
            InitializeComponent();
            DBConnects dbcn = new DBConnects();
            SqlConnection dbc = new SqlConnection();
            dbc = new SqlConnection(dbcn.DBConnection1());
          
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgprdctlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
            dgprdctlist.DataSource = dtbl;
            dbc.Close();
        }
    }
}
