using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Update : Form
    {
        string fname = null;
        string lname = null;
        string gender = null;   
        string grade = null;
        string address = null;
        string id = null;
        public Update(string fname,string lname,string gender,string grade,string address,string id) 
        {
            InitializeComponent();
            this.fname  = fname;
            this.lname = lname;
            this.gender = gender;
            this.grade = grade;
            this.address = address;
            this.id = id;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = this.fname;
            txtLastName.Text = this.lname;

            if (this.gender == "Male")
            {
                radioMale.Checked =true;
            }
            else if (this.gender == "Female")
            {
                radioFemale.Checked = true;
            }

            comGrade.Text = this.grade;
            txtAddress.Text = this.address;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (radioMale.Checked)
            {
                gender = radioMale.Text;
            }
            else if (radioFemale.Checked)
            {
                gender = radioFemale.Text;
            }

            string sql = "UPDATE [students] SET [first_name]= '" + txtFirstName.Text + "', [last_name] = '" + txtLastName.Text + "',[gender]='" + gender + "', [grade]='" + comGrade.Text + "', [address] = '" + txtAddress.Text + "' WHERE[id] = '" + this.id + "'";
            string connetionString = "Server =DESKTOP-8MI6B22; Database =CsharpDp; Trusted_Connection = True";
            SqlConnection con = new SqlConnection(connetionString);

                
            try
            {

                con.Open();
                SqlCommand command = new SqlCommand(sql, con);
                //command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show("Update successfully !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Can not open connection ! ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
            }
            
        }
    }
}
