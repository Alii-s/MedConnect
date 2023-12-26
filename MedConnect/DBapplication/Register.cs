using MedConnect.Patient;
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
using ComponentFactory.Krypton.Toolkit;
using MedConnect.Secretary;

namespace MedConnect
{
    public partial class Register : Form
    {
        Controller controller = new Controller();
        bool Validation = true;
        int userID;
        int SecretaryID;
        public Register(int SecretaryID=-1)
        {
            this.SecretaryID = SecretaryID;
            InitializeComponent();
            genderComboBox.SelectedIndex = 0;
            maritalStateTextBox.SelectedIndex = 0 ;
        }
        #region Validation Functions
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
        private bool isOccupation()
        {
            if (occupationTextBox.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool isMaritalStatus()
        {
            if (maritalStateTextBox.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool isAdress()
        {
            if (cityTextBox.Text == "" || buildingNoTextBox.Text == "" || streetNameTextBox.Text == "")
            {
                return false;
            }
            return true;
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
        #endregion
        //////////////////
        #region events
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SecretaryID == -1)
            {
                Trigger trigger = new Trigger();
                trigger.Show();
                this.Close();
            }
            else
            {
                Secretary.Secretary secretary = new Secretary.Secretary(SecretaryID);
                secretary.Show();
                this.Close();
            }
            
        }
        #region Focus
        private void label4_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lastNameTextBox.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            emailTextBox.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {
            dateTimeBox.Focus();
        }
        #endregion
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (!isValidEmail())
            {
                emailValidationLabel.Visible = true;
                Validation = false;
            }
            else
            {
                emailValidationLabel.Visible = false;
            }

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
            if (!isOccupation())
            {
                occupationLabel.Visible = true;
                Validation = false;
            }
            else
            {
                occupationLabel.Visible = false;
            }
            //if (!isMaritalStatus())
            //{
            //    maritalStateLabel.Visible = true;
            //    Validation = false;
            //}
            //else
            //{
            //    maritalStateLabel.Visible = false;
            //}
            if (!isAdress())
            {
                addressLabel.Visible = true;
                Validation = false;
            }
            else
            {
                addressLabel.Visible = false;
            }
            if (!isPassword())
            {
                passwordLabel.Visible = true;
                Validation = false;
            }
            else
            {
                passwordLabel.Visible = false;
            }
            if (!isConfirmPassword())
            {
                passwordConfirmationLabel.Visible = true;
                Validation = false;
            }
            else
            {
                passwordConfirmationLabel.Visible = false;
            }
            if (!(isFirstName() && isLastName() && isValidEmail() && isValidPhone() && isOccupation() && isAdress()&&isPassword()&&isConfirmPassword()))
            {
                return;
            }
            if (controller.Register(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, phoneNumberTextBox.Text, genderComboBox.Text, passwordTextBox.Text, dateTimeBox.Value, occupationTextBox.Text, cityTextBox.Text, int.Parse(buildingNoTextBox.Text), streetNameTextBox.Text, maritalStateTextBox.Text,SecretaryID) == 2)
            {
                userID = int.Parse(controller.RetrieveID(emailTextBox.Text).ToString());
                if (SecretaryID == -1)
                {
                    PatientMainForm f = new Patient.PatientMainForm(userID);
                    KryptonMessageBox.Show("Registered Successfully, You will be now logged in");
                    f.Show();
                    this.Close();
                    return;
                }
                Secretary.Secretary secretary = new Secretary.Secretary(SecretaryID);
                secretary.Show();
                KryptonMessageBox.Show("User Registered Successfully");


            }
            else
            {
                label11.Visible = true;
                return;
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

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void buildingNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }
        #endregion
    }
}
