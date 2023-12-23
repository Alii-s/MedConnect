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
using System.Xml.Linq;
using MedConnect.Patient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MedConnect.Secertary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedConnect.Secretary
{
    
    public partial class UpdatePatientSec : Form
    {
        PatientController PatientController = new PatientController();
        SecretaryController SecretaryController = new SecretaryController();
        int UserID;  //Secretary
        int PatientID;
        public UpdatePatientSec(int userID)
        {
            InitializeComponent();
            UserID = userID;
           
            DataTable dt = SecretaryController.SelectPatientsName();
            PatientNameComboBox.DataSource = dt;
            PatientNameComboBox.ValueMember = "UserID";
            PatientNameComboBox.DisplayMember = "Lname";
             

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
        private bool isOccupation()
        {
            if (occupationTextBox.Text != "")
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
        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Secretary frm = new Secretary(UserID);
            frm.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            phoneNumberTextBox.Enabled = true;
            maritalStateTextBox.Enabled = true;
            occupationTextBox.Enabled = true;
            cityTextBox.Enabled = true;
            buildingNoTextBox.Enabled = true;
            streetNameTextBox.Enabled = true;
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
            if (!isOccupation())
            {
                occupationLabel.Visible = true;
                Validation = false;
            }
            else
            {
                occupationLabel.Visible = false;
            }
            if (!isAdress())
            {
                addressLabel.Visible = true;
                Validation = false;
            }
            else
            {
                addressLabel.Visible = false;
            }
            if (!(isFirstName() && isLastName() && isValidEmail() && isValidPhone() && isOccupation() && isAdress()))
            {
                return;
            }
            //Don't Allow Edits after validating
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            maritalStateTextBox.Enabled = false;
            phoneNumberTextBox.Enabled = false;
            occupationTextBox.Enabled = false;
            cityTextBox.Enabled = false;
            buildingNoTextBox.Enabled = false;
            streetNameTextBox.Enabled = false;
            editButton.Enabled = true;
            editButton.Visible = true;
            doneButton.Visible = false;
            doneButton.Enabled = false;
            //updating database
            SecretaryController.UpdatePatientInfo(UserID, Convert.ToInt32(PatientNameComboBox.SelectedValue),firstNameTextBox.Text, lastNameTextBox.Text, phoneNumberTextBox.Text, occupationTextBox.Text, cityTextBox.Text, int.Parse(buildingNoTextBox.Text), streetNameTextBox.Text, maritalStateTextBox.Text);
            KryptonMessageBox.Show("Info Editted Successfully");
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
            occupationTextBox.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            maritalStateTextBox.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            cityTextBox.Focus();
        }

        private void cityNameLabel_Click(object sender, EventArgs e)
        {
            cityTextBox.Focus();
        }

        private void cityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                CityLabel.Visible = true;
            }
            else
                CityLabel.Visible = false;
        }

        private void buildingNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buildingNoTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                BnumLabel.Visible = true ;
            }
            else
                BnumLabel.Visible = false;

        }

        private void streetNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                StN.Visible = true;
            }
            else
                StN.Visible = false;
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdatePatientSec_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click_1(object sender, EventArgs e) //go button after select patient name
        {
              int BuildingNum;
             string Fname, Lname, Email, PhoneNumber, Gender, Occupation, Street_Name, City, Marital_State;
              DateTime DateOfBirth;
           
              DataTable userData;
            userData = PatientController.SelectPatientInfo(Convert.ToInt32(PatientNameComboBox.SelectedValue));
            Fname = userData.Rows[0][0].ToString();
            Lname = userData.Rows[0][1].ToString();
            Email = userData.Rows[0][2].ToString();
            PhoneNumber = userData.Rows[0][3].ToString();
            Gender = userData.Rows[0][4].ToString();
            DateOfBirth = DateTime.Parse(userData.Rows[0][5].ToString());
            Occupation = userData.Rows[0][6].ToString();
            BuildingNum = int.Parse(userData.Rows[0][7].ToString());
            Street_Name = userData.Rows[0][8].ToString();
            City = userData.Rows[0][9].ToString();
            Marital_State = userData.Rows[0][10].ToString();

            firstNameTextBox.Text = Fname;
            lastNameTextBox.Text = Lname;
            emailTextBox.Text = Email;
            phoneNumberTextBox.Text = PhoneNumber;
            occupationTextBox.Text = Occupation;
            for (int i = 0; i < maritalStateTextBox.Items.Count; i++)
            {
                if (maritalStateTextBox.Items[i].ToString() == Marital_State)
                {
                    maritalStateTextBox.SelectedIndex = i;
                    break;
                }
            }
            cityTextBox.Text = City;
            buildingNoTextBox.Text = BuildingNum.ToString();
            streetNameTextBox.Text = Street_Name;
            panel1.Visible = true;
        }

        private void buildingNoLabel_Click(object sender, EventArgs e)
        {
            buildingNoTextBox.Focus();
        }

        private void streetNameLabel_Click(object sender, EventArgs e)
        {
            streetNameTextBox.Focus();
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

        private void buildingNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }

        private void maritalStateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            else if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                // Suppress the key press
                e.Handled = true;
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void Patient_Info_Load(object sender, EventArgs e)
        {
           
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Secretary form = new Secretary(UserID);
            form.Show();
        }
    }
}
