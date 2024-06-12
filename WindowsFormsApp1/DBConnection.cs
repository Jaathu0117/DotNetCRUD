using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DBConnection : Form
    {
        public DBConnection()
        {
            InitializeComponent();
        }
        string id;
        private void btnTest_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            //connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            sql = "Select * from students";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            //connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            sql = "Select * from students";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnGetAllStudents_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            //connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            sql = "Select * from students";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                SqlDataReader sqlReader = command.ExecuteReader();

                //while (sqlReader.Read())
                //{
                //    MessageBox.Show(sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1) + " - " + sqlReader.GetValue(2));
                //}

                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                stuTable.DataSource = dt;

                sqlReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create f = new Create(); 
            f.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (stuTable.SelectedRows.Count > 0)
            {

                string id = stuTable.CurrentRow.Cells["id"].Value.ToString();

                DialogResult dr = MessageBox.Show("Do you want to Delete?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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
            
        }

        private void btngetStudent_Click(object sender, EventArgs e)
        {
            // string id = dataGridView1.SelectedRows[1].Cells["id"].Value.ToString();
            string id = stuTable.CurrentRow.Cells["id"].Value.ToString();

            MessageBox.Show(id);
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
                }else if(dr == DialogResult.Yes) 
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
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            //sql = "Select * from students where name='" + txtFirstName.Text + "'";
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

        private void stuTable_SelectionChanged(object sender, EventArgs e)
        {

            btnSubmit.Text = "Update";
            this.id = stuTable.CurrentRow.Cells["id"].Value.ToString();
            string first_name = stuTable.CurrentRow.Cells["first_name"].Value.ToString();
            string last_name = stuTable.CurrentRow.Cells["last_name"].Value.ToString();
            string gender = stuTable.CurrentRow.Cells["gender"].Value.ToString();
            string grade = stuTable.CurrentRow.Cells["grade"].Value.ToString();
            string address = stuTable.CurrentRow.Cells["address"].Value.ToString();



            txtFirstName.Text = first_name;
            txtLastName.Text = last_name;
            txtAddress.Text = address;
            comGrade.Text = grade;
            if (gender == "Male")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text=="Save")
            {
                
                string connetionString = null;
                string gender = null;
                if (radioMale.Checked)
                {
                    gender = "Male";
                }
                else if (radioFemale.Checked)
                {
                    gender = "Female";
                }
                
                SqlConnection connection;
                SqlCommand command;
                connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
                string sql = "INSERT INTO students (first_name, last_name, grade,address, gender) VALUES('" + txtFirstName.Text + "', '" + txtLastName.Text + "','" + comGrade.Text + "','" + txtAddress.Text + "','" + gender + "');";
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
                
            }
            else 
            {
                string connetionString = null;
                string gender = null;
                if (radioMale.Checked)
                {
                    gender = "Male";
                }
                else if (radioFemale.Checked)
                {
                    gender = "Female";
                }

                SqlConnection connection;
                SqlCommand command;
                string sql = null;
                connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
                sql = "UPDATE [students] SET [first_name] = '" + txtFirstName.Text + "', [last_name] = '" + txtLastName.Text + "',[gender]='" + gender + "', [grade]='" + comGrade.Text + "',[address]='" + txtAddress.Text + "' WHERE [id]='" + this.id + "';";
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

            }
            
            
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.id=null;
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtAddress.Text = null;
            comGrade.SelectedIndex = -1;
            radioMale.Checked = false;

            btnSubmit.Text = "Save";


        }
    }
    
}
