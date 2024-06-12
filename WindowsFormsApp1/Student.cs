using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {
        String fname;
        String lname;
        String gender;
        String grade;
        String address;
        public Student()
        {
            
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {/*
            fname = this.txtFirstName.Text;
            lname = this.txtLastName.Text;
            if (radioMale.Checked)
            { 
                gender = radioMale.Text;
            }
            else if(radioFemale.Checked)
            {
                gender = radioFemale.Text;
            }

            grade = this.comGrade.Text;
            address =this.txtAddress.Text;

            View f =new View(fname,lname,gender,grade,address);
            f.Show;
            */
            View f = new View();
            f.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            //connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            sql = "INSERT INTO students (first_name, last_name,gender, grade,address ) VALUES('" + txtFirstName.Text + "', '"+ txtLastName.Text + "','" + gender + "','" + comGrade.Text + "','"+ txtAddress.Text + "');";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Save Sucuessfully","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ","Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Refresh();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create f = new Create();
            f.ShowDialog();
        }

        private void Refresh()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            radioMale.Checked = false;
            radioFemale.Checked = false;
            comGrade.Text = "";
            txtAddress.Clear();
        }
    }
}
