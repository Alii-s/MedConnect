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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedConnect.Admin
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            Dictionary<char, string> dataSource = new Dictionary<char, string>
            {
                { 'A', "Admin" },
                { 'P', "Patient" },
                { 'F', "Pharmacist" },
                { 'S', "Secretary" },
                { 'F', "Doctor" },
            };
            userType.DataSource = new BindingSource(dataSource, null);
            userType.DisplayMember = "Value";
            userType.ValueMember = "Key";
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            dateTimeBox.Focus();
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

        private void label9_Click(object sender, EventArgs e)
        {
            genderComboBox.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            passwordTextBox.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            passwordConfirmTextBox.Focus();
        }
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
        private bool isPassword()
        {
            if (passwordTextBox.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool isConfirmPassword()
        {
            if (passwordTextBox.Text == passwordConfirmTextBox.Text)
            {
                return true;
            }
            return false;
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (!isValidEmail())
            {
                emailValidationLabel.Visible = true;
            }
            else
            {
                emailValidationLabel.Visible = false;
            }

            if (!isValidPhone())
            {
                phoneNumberValidationLabel.Visible = true;
            }
            else
            {
                phoneNumberValidationLabel.Visible = false;
            }
            if (!isFirstName())
            {
                firstNameLabel.Visible = true;
            }
            else
            {
                firstNameLabel.Visible = false;
            }
            if (!isLastName())
            {
                lastNameLabel.Visible = true;
            }
            else
            {
                lastNameLabel.Visible = false;
            }
        }
    }
}
