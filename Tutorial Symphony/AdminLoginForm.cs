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
    public partial class AdminLoginForm : Form
    {
        SqlConnection dbc = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnects dbcn = new DBConnects();
        public AdminLoginForm()

        {
            InitializeComponent();
            dbc = new SqlConnection(dbcn.DBConnection1());
        }

        private void Admin_lgn_btn_Click(object sender, EventArgs e)
        {
            if (text_admn_username.Text == "")
            {
                MessageBox.Show("Please enter Username");
            }
            else if (text_admn_pwrd.Text == "")
            {
                MessageBox.Show("Please enter Password");

            }
            else
            {
                try
                {
                    dbc.Open();
                    String sql = "Select User_name,Pass_word from TblAdmin";
                    SqlCommand cmd = new SqlCommand(sql, dbc);


                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        if(sqlDataReader.GetValue(0).ToString()==text_admn_username.Text && sqlDataReader.GetValue(1).ToString() == text_admn_pwrd.Text)
                        {
                            MainForm frm = new MainForm();
                            frm.ShowDialog();
                            this.Close();
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Username or password invalid! Attempts are finished! Rolling Back");
                    AdminLoginForm adfrm = new AdminLoginForm();
                    adfrm.Hide();
                    LoginForm lgfrm = new LoginForm();
                    lgfrm.ShowDialog();

                }
            }
            
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void text_admn_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_admin_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
