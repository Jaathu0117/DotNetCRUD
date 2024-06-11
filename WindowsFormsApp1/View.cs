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

namespace WindowsFormsApp1
{
    public partial class View : Form
    {
        
        public View()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            sql = "Select * from students";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stuTable.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void stdtable_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (stuTable.SelectedRows.Count > 0)
            {

                string id = stuTable.CurrentRow.Cells["id"].Value.ToString();

                DialogResult dr = MessageBox.Show("Do you want to Change?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    int selectedIndex = stuTable.SelectedRows[0].Index;
                    string first_name = stuTable.CurrentRow.Cells["first_name"].Value.ToString();
                    string last_name = stuTable.CurrentRow.Cells["last_name"].Value.ToString();
                    string gender = stuTable.CurrentRow.Cells["gender"].Value.ToString();
                    string grade = stuTable.CurrentRow.Cells["grade"].Value.ToString();
                    string address = stuTable.CurrentRow.Cells["address"].Value.ToString();
                    //string id = stuTable.CurrentRow.Cells["id"].Value.ToString();

                    Update f = new Update(first_name, last_name, gender, grade, address, id);
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
            //this.Close();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (stuTable.SelectedRows.Count > 0)
            {

                string id = stuTable.CurrentRow.Cells["id"].Value.ToString();

                DialogResult dr = MessageBox.Show("Do you want to Delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }

                int selectedIndex = stuTable.SelectedRows[0].Index;
                string sql = "DELETE FROM students WHERE id ='" + id + "'";
                string connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
                SqlConnection con = new SqlConnection(connetionString);

                {
                    try
                    {

                        con.Open();
                        SqlCommand command = new SqlCommand(sql, con);
                        //command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Row deleted successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete row! ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create f = new Create();
            f.ShowDialog();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            //sql = "Select * from students where name='" + txtFirstName.Text+ "'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                stuTable.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
