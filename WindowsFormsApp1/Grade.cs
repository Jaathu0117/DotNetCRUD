using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Grade : Form
    {

        string id;
        public Grade()
        {
            InitializeComponent();
        }

        private void gradeview_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            sql = "INSERT INTO grades ( grade) VALUES('" + txtGrade.Text + "');";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Save Sucuessfully", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not open connection ! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh();
            reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gradeview.SelectedRows.Count > 0)
            {

                string id = gradeview.CurrentRow.Cells["id"].Value.ToString();

                DialogResult dr = MessageBox.Show("Do you want to Change?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    string connetionString = null;
                    SqlConnection connection;
                    SqlCommand command;
                    string sql = null;
                    connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
                    sql = "UPDATE [grades] SET [grade]='" + txtGrade.Text + "' WHERE [id]='" + this.id + "';";
                    connection = new SqlConnection(connetionString);
                    try
                    {
                        connection.Open();
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Close();
                        MessageBox.Show(" Update Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Can not open connection ! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Refresh();
                    reset();

                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gradeview.SelectedRows.Count > 0)
            {

                string id = gradeview.CurrentRow.Cells["id"].Value.ToString();

                DialogResult dr = MessageBox.Show("Do you want to Delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }

                int selectedIndex = gradeview.SelectedRows[0].Index;
                string sql = "DELETE FROM grades WHERE id ='" + id + "'";
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
                    Refresh();
                    reset();

                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Grade_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            sql = "Select * from grades";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gradeview.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void Refresh()
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            sql = "Select * from grades";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlReader = command.ExecuteReader();


                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                gradeview.DataSource = dt;

                sqlReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void gradeview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = gradeview.CurrentRow.Cells["id"].Value.ToString();
            string grade = gradeview.CurrentRow.Cells["grade"].Value.ToString();
            txtGrade.Text = grade;
            
        }

        private void reset()
        {
            this.id = null;
            txtGrade.Text = null;
            
        }

        
    }
}
