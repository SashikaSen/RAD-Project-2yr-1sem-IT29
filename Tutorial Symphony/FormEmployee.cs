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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnects dbcn = new DBConnects();
            SqlConnection dbc = new SqlConnection();
            dbc = new SqlConnection(dbcn.DBConnection1());
            dbc.Open();
            SqlDataAdapter sqlda2 = new SqlDataAdapter("SELECT * FROM Employee", dbc);
            DataTable dtbl1 = new DataTable();
            sqlda2.Fill(dtbl1);
            dgemployee.DataSource = dtbl1;
            dbc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employeemgr frm = new Employeemgr();
            frm.ShowDialog();
        }
    }
}
