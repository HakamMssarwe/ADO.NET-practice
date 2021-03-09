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
using System.Text.RegularExpressions;

namespace Backend_Practice
{
    public partial class ManageUsers : Form
    {
        static string connectionString = @"Data Source=HAKAM\SQLEXPRESS;Initial Catalog=DBProjectManagerTest;Integrated Security=True";
        
        string emailValidation = @"[a-zA-Z0-9]{1,12}@[a-zA-Z0-9]{1,12}.[a-zA-Z]";
        int passwordMinimumLength = 6;

        ManagementFrom managementForm;

        public ManageUsers()
        {
            InitializeComponent();

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

       

        private void signupBtn_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex(emailValidation);


            bool checkForEmptyInputs =
                usernameInput.Text == "" && emailInput.Text == "" && firstnameInput.Text == "" &&
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

            else if (!regex.IsMatch(emailInput.Text))
            {
                MessageBox.Show("Incorrect email format!");
                return;
            }

            else if (passwordInput.Text.Length < passwordMinimumLength)
            {
                MessageBox.Show("Password too short!");
                return;
            }



            string optionSelected = "";

            foreach(Control option in roleGB.Controls)
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

            using (SqlConnection connection = new SqlConnection(connectionString)) //this creates an instance, uses it, when it finishes using it will dispose the object
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO [dbo].[TBUsers] ([username],[firstName],[lastName],[email],[password],[avatar],[role],[isAdmin],[state],[address]) VALUES" +
                            $" ('{usernameInput.Text}', '{firstnameInput.Text}', '{lastnameInput.Text}','{emailInput.Text}','{passwordInput.Text}','{avatarURLInput.Text}','{optionSelected}','{statusSelected}','{stateInput.Text}','{addressInput.Text}')";
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Username already exists!");
                        return;
                    }
                }

                connection.Close();
            }


            MessageBox.Show("Successfully signed up!");
            ClearForm();

        }


        #region keypress functions
        private void usernameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void firstnameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lastnameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void stateInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addressInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        private void ClearForm()
        {
            usernameInput.Text = "";
            emailInput.Text = "";
            firstnameInput.Text = "";
            lastnameInput.Text = "";
            stateInput.Text = "";
            addressInput.Text = "";
            passwordInput.Text = "";
            confirmPasswordInput.Text = "";
            avatarURLInput.Text = "";
            usernameInput.Text = "";
            FullstackOption.Checked = true;
            MemberStatusOption.Checked = true;


        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            managementForm = new ManagementFrom(this);
            managementForm.Show();
            Hide();
        }
    }
}
