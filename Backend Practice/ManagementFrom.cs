using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Backend_Practice
{
    public partial class ManagementFrom : Form
    {
        ManageUsers manageUsers;
        static string connectionString = @"Data Source=HAKAM\SQLEXPRESS;Initial Catalog=DBProjectManagerTest;Integrated Security=True";
        int passwordMinimumLength = 6;


        public ManagementFrom(ManageUsers manageUsers)
        {
            InitializeComponent();
            this.manageUsers = manageUsers;
        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            manageUsers.Show();
            this.Close();
        }

        private void ManagementFrom_Load(object sender, EventArgs e)
        {


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"DELETE FROM [dbo].[TBUsers] WHERE username = '{userSearchInput.Text}'";
                    command.ExecuteNonQuery();
                    MessageBox.Show("User was deleted successfully!");
                    ClearForm();


                }


            }




        }



        private void findUserBtn_Click(object sender, EventArgs e)
        {



            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"select * from TBUsers where username = '{userSearchInput.Text}'";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            userEmailInput.Text = reader["email"].ToString();
                            firstnameInput.Text = reader["firstName"].ToString();
                            lastnameInput.Text = reader["lastName"].ToString();
                            stateInput.Text = reader["state"].ToString();
                            addressInput.Text = reader["address"].ToString();
                            avatarURLInput.Text = reader["avatar"].ToString();
                            passwordInput.Text = reader["password"].ToString();
                            confirmPasswordInput.Text = reader["password"].ToString();


                            foreach (Control control in roleGB.Controls)
                                if (((RadioButton)control).Text == reader["role"].ToString())
                                    ((RadioButton)control).Checked = true;


                            foreach (Control control in statusGB.Controls)
                                if (reader["isAdmin"].ToString() == "True" && ((RadioButton)control).Text == "Admin")
                                    ((RadioButton)control).Checked = true;

                                else if (reader["isAdmin"].ToString() == "False" && ((RadioButton)control).Text == "Member")
                                    ((RadioButton)control).Checked = true;
                        }

                    else
                    {
                        MessageBox.Show("username does not exist!");
                        ClearForm();
                    }

                }

                connection.Close();





            }




        }

        private void updateBtn_Click(object sender, EventArgs e)
        {


            bool checkForEmptyInputs =
               userEmailInput.Text == "" && firstnameInput.Text == "" &&
               lastnameInput.Text == "" && stateInput.Text == "" && addressInput.Text == "" &&
               avatarURLInput.Text == "" && passwordInput.Text == "" && confirmPasswordInput.Text == "";

            if (checkForEmptyInputs)
            {
                MessageBox.Show("Please do not leave any empty fields!");
                return;
            }
            else if (passwordInput.Text != confirmPasswordInput.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }


            else if (passwordInput.Text.Length < passwordMinimumLength)
            {
                MessageBox.Show("Password too short!");
                return;
            }


            try
            {
                MailAddress m = new MailAddress(userEmailInput.Text);

            }

            catch (FormatException)
            {
                MessageBox.Show("Invalid Email Address!");
                return;
            }



            string optionSelected = "";

            foreach (Control option in roleGB.Controls)
            {

                RadioButton radio = (RadioButton)option;

                if (radio.Checked)
                    optionSelected = radio.Text;
            }

            string statusSelected = "";

            foreach (Control option in statusGB.Controls)
            {

                RadioButton radio = (RadioButton)option;

                if (radio.Checked)
                    statusSelected = radio.Text;
            }


            statusSelected = statusSelected == "Admin" ? "1" : "0";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $@"UPDATE [dbo].[TBUsers] SET [firstName] = '{firstnameInput.Text}' , [lastName] = '{lastnameInput.Text}' , [email] = '{userEmailInput.Text}' , [password] = '{passwordInput.Text}' , [avatar] = '{avatarURLInput.Text}' , [role] = '{optionSelected}' , [isAdmin] = '{statusSelected}' , [state] = '{stateInput.Text}' , [address] = '{addressInput.Text}' WHERE username = '{userSearchInput.Text}'";
                    command.ExecuteNonQuery();
                
                }
                connection.Close();

            }


            MessageBox.Show("Updated sucessfully!");





        }

        private void ClearForm()
        {
            userSearchInput.Text = "";
            userEmailInput.Text = "";
            firstnameInput.Text = "";
            lastnameInput.Text = "";
            stateInput.Text = "";
            addressInput.Text = "";
            passwordInput.Text = "";
            confirmPasswordInput.Text = "";
            avatarURLInput.Text = "";
            FullstackOption.Checked = true;
            MemberStatusOption.Checked = true;


        }





    }
}


