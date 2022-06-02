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
    public partial class Employeemgr : Form
    {
        SqlConnection dbc = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnects dbcn = new DBConnects();
        public Employeemgr()
        {
            InitializeComponent();
            dbc = new SqlConnection(dbcn.DBConnection1());
        }

        private void btn_save_emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm the Save?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.Open();

                    String sql = " insert into  Employee(Employee_ID,Employee_Name,Position)values(@empid,@empname,@posi)";
                    SqlCommand cmd = new SqlCommand(sql, dbc);
                    cmd.Parameters.AddWithValue("@empid", text_emp_id.Text);
                    cmd.Parameters.AddWithValue("@empname", text_emp_name.Text);
                    cmd.Parameters.AddWithValue("@posi", text_emp_posi.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Saved!");



                    dbc.Close();
                }
            }
            catch
            {
                MessageBox.Show("Cant insert same values for the primary key");
                dbc.Close();

            }
            
           
        }

        private void btn_update_emp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm the Update?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbc.Open();

                String sql = "UPDATE Employee SET Employee_Name=@empname,Position=@posi WHERE Employee_ID=(@empid)";
                SqlCommand cmd = new SqlCommand(sql, dbc);
                cmd.Parameters.AddWithValue("@empid", text_emp_id.Text);
                cmd.Parameters.AddWithValue("@empname", text_emp_name.Text);
                cmd.Parameters.AddWithValue("@posi", text_emp_posi.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Updated!");
                dbc.Close();
            }
        }

        private void btn_delete_emp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm the Deletion?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbc.Open();

                String sql = "  DELETE FROM Employee WHERE Employee_ID=(@empid)";
                SqlCommand cmd = new SqlCommand(sql, dbc);
                cmd.Parameters.AddWithValue("@empid", text_emp_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Deleted!");
                dbc.Close();

            }
        }
    }
}
