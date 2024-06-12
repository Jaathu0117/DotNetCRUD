using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
            //sql = "INSERT INTO [students] ([first_name], [last_name], [gender], [address], [grade]) VALUES('txtFirstName.Text','txtLastName.Text', '', 'cmdGender', '"+txtAddress.Text+"')";
            sql = "INSERT INTO students (first_name, last_name, grade,address, gender) VALUES('" + txtFirstName.Text + "', '"+ txtLastName.Text + "','" + comGrade.Text + "','"+ txtAddress.Text + "','" + gender + "');";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Save Sucuessfully","Info",MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not open connection ! ","Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }
    }
}
