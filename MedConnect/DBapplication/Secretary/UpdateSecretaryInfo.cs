using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedConnect.Patient;
using MedConnect.Secertary;

namespace MedConnect.Secretary
{
    public partial class UpdateSecretaryInfo : Form
    {
        readonly int UserID, Salary;
        readonly string Fname, Lname, Email, PhoneNumber, Gender;
        readonly DateTime DateOfBirth;
        SecretaryController SecretaryController = new SecretaryController();
        readonly DataTable userData;

        public UpdateSecretaryInfo(int userID)
        {
            InitializeComponent();

            UserID = userID;
            DataTable userData = SecretaryController.SelectSecrtaryInfo(userID);
            Fname = userData.Rows[0][1].ToString();
            Lname = userData.Rows[0][2].ToString();
            Email = userData.Rows[0][3].ToString();
            PhoneNumber = userData.Rows[0][4].ToString();
            Gender = userData.Rows[0][5].ToString();
            DateOfBirth = DateTime.Parse(userData.Rows[0][7].ToString());
            Salary = int.Parse(userData.Rows[0][8].ToString());

            firstNameTextBox.Text = Fname;
            lastNameTextBox.Text = Lname;
            emailTextBox.Text = Email;
            phoneNumberTextBox.Text = PhoneNumber;
            SalaryTextBox.Text = Salary.ToString();

        }

        bool Validation = true;
        private bool isFirstName()
        {
            if (firstNameTextBox.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool isLastName()
        {
            if (lastNameTextBox.Text != "")
            {
                return true;
            }
            return false;
        }




        private bool isValidEmail()
        {
            string email = emailTextBox.Text.Trim();

            // Use a regular expression to check if the email is valid
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);

        }
        private bool isValidPhone()
        {
            string phoneNumber = phoneNumberTextBox.Text.Trim();
            // Use a regular expression to check if the phone number is valid from egypt
            string phonePattern = @"^(01)\d{9}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void kryptonButton1_Click(object sender, EventArgs e) //edit button
        {
            firstNameTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            phoneNumberTextBox.Enabled = true;
            SalaryTextBox.Enabled = true;
            editButton.Enabled = false;
            editButton.Visible = false;
            doneButton.Visible = true;
            doneButton.Enabled = true;
            emailTextBox.Enabled = true;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (!isValidPhone())
            {
                phoneNumberValidationLabel.Visible = true;
                Validation = false;
            }
            else
            {
                phoneNumberValidationLabel.Visible = false;
            }
            if (!isFirstName())
            {
                firstNameLabel.Visible = true;
                Validation = false;
            }
            else
            {
                firstNameLabel.Visible = false;
            }
            if (!isLastName())
            {
                lastNameLabel.Visible = true;
                Validation = false;
            }
            else
            {
                lastNameLabel.Visible = false;
            }


            if (!(isFirstName() && isLastName() && isValidEmail() && isValidPhone()))
            {
                return;
            }
            //Don't Allow Edits after validating
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;

            phoneNumberTextBox.Enabled = false;
            SalaryTextBox.Enabled = false;

            editButton.Enabled = true;
            editButton.Visible = true;
            doneButton.Visible = false;
            doneButton.Enabled = false;
            //updating database
            SecretaryController.UpdateSecretaryInfo(UserID, firstNameTextBox.Text.ToString(), lastNameTextBox.Text.ToString(), phoneNumberTextBox.Text.ToString(), Convert.ToInt32(SalaryTextBox.Text));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lastNameTextBox.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            emailTextBox.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            phoneNumberTextBox.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            SalaryTextBox.Focus();
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                SalaryLabel.Visible = true;
            }

            else
            {
                SalaryLabel.Visible = false;
            }

        }



        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Secretary frm = new Secretary(UserID);
            frm.Show();
        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a letter
            if (char.IsLetter(e.KeyChar))
            {
                // If it's the first letter, convert it to uppercase
                if (firstNameTextBox.SelectionStart == 0)
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
                // If it's not the first letter, convert it to lowercase
                else
                {
                    e.KeyChar = char.ToLower(e.KeyChar);
                }
            }
            // If it's not a letter, allow Backspace and Space
            else if (e.KeyChar != (char)Keys.Back)
            {
                // Suppress the key press
                e.Handled = true;
            }
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a letter
            if (char.IsLetter(e.KeyChar))
            {
                // If it's the first letter, convert it to uppercase
                if (lastNameTextBox.SelectionStart == 0)
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
                // If it's not the first letter, convert it to lowercase
                else
                {
                    e.KeyChar = char.ToLower(e.KeyChar);
                }
            }
            // If it's not a letter, allow Backspace and Space
            else if (e.KeyChar != (char)Keys.Back)
            {
                // Suppress the key press
                e.Handled = true;
            }
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }





        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }




    }

}
  

