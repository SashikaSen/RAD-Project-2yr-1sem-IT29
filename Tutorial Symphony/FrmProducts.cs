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
    public partial class FrmProducts : Form
    {

        SqlConnection dbc = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnects dbcn = new DBConnects();
        public FrmProducts()
        {
            InitializeComponent();
            dbc = new SqlConnection(dbcn.DBConnection1());
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Product_manager_Load(object sender, EventArgs e)
        {

        }
       

        private void Save_button_Click(object sender, EventArgs e)
        {
            try {

                if (MessageBox.Show("Confirm the Save?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.Open();
                   
                    String sql = "SET IDENTITY_INSERT Product ON; insert into  Product(ID,Product_name,Stock,Unit_price)values(@id,@prdctname,@stock,@unitprice)";
                    SqlCommand cmd = new SqlCommand(sql, dbc);
                    cmd.Parameters.AddWithValue("@id", text_prdct_id.Text);
                    cmd.Parameters.AddWithValue("@prdctname", text_prdct_name.Text);
                    cmd.Parameters.AddWithValue("@stock", text_prdct_stock.Text);
                    cmd.Parameters.AddWithValue("@unitprice", text_prdct_unitprice.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records Saved!");
                    dbc.Close();

                }
                }
            catch
            {

            }

            
       
               
            
            
        }

        private void text_prdct_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm the Deletion?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbc.Open();

                String sql = "SET IDENTITY_INSERT Product ON; DELETE FROM Product WHERE ID=(@id)";
                SqlCommand cmd = new SqlCommand(sql, dbc);
                cmd.Parameters.AddWithValue("@id", text_prdct_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Deleted!");
                dbc.Close();

            }
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm the Update?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbc.Open();

                String sql = "SET IDENTITY_INSERT Product ON; UPDATE Product SET Product_name=@prdctname,Stock=@stock,Unit_price=@unitprice WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(sql, dbc);
                cmd.Parameters.AddWithValue("@id", text_prdct_id.Text);
                cmd.Parameters.AddWithValue("@prdctname", text_prdct_name.Text);
                cmd.Parameters.AddWithValue("@stock", text_prdct_stock.Text);
                cmd.Parameters.AddWithValue("@unitprice", text_prdct_unitprice.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Updated!");
                dbc.Close();
            }
        }

        private void text_prdct_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
