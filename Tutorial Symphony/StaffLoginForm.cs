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
    public partial class StaffLoginForm : Form
    {
        SqlConnection dbc = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnects dbcn = new DBConnects();
        
        public StaffLoginForm()
        {
            InitializeComponent();
            dbc = new SqlConnection(dbcn.DBConnection1());
        }

        private void staff_login_btn_Click(object sender, EventArgs e)
        {
           
                if(text_staff_username1.Text == "")
                {
                    MessageBox.Show("Please enter Username");
                }
                else if (text_staff_pwrd1.Text == "")
                {
                    MessageBox.Show("Please enter Password");

                }
                else
                {
                    try
                    {
                        dbc.Open();
                        String sql = "Select User_name,Pass_word from Tbl_Staff";
                        SqlCommand cmd = new SqlCommand(sql, dbc);

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        if (sqlDataReader.GetValue(0).ToString() == text_staff_username1.Text && sqlDataReader.GetValue(1).ToString() == text_staff_pwrd1.Text)
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
                    StaffLoginForm stfrm = new StaffLoginForm();
                    stfrm.Hide();
                    LoginForm lgfrm = new LoginForm();
                        lgfrm.ShowDialog();
                    }


                }



            


        }

        private void StaffLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
