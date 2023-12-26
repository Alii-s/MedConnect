﻿using ComponentFactory.Krypton.Toolkit;
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
        int UserID;
        DataTable UserTypes = new DataTable("MyTable");
        DataColumn idColumn = new DataColumn("Character", typeof(char));
        DataColumn nameColumn = new DataColumn("Type", typeof(string));
        public AddUser(int UserID)
        {
            UserTypes.Columns.Add(idColumn);
            UserTypes.Columns.Add(nameColumn);
            UserTypes.Rows.Add('A', "Admin");
            UserTypes.Rows.Add('P', "Patient");
            UserTypes.Rows.Add('D', "Doctor");
            UserTypes.Rows.Add('S', "Secretary");
            UserTypes.Rows.Add('F', "Pharmacist");
            this.UserID = UserID;
            InitializeComponent();
            userType.DataSource = UserTypes;
            userType.DisplayMember = "Type";
            userType.ValueMember = "Character";
            genderComboBox.SelectedIndex = 0;
            maritalStateTextBox.SelectedIndex = 0;
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
        private bool isCertificate()
        {
            if (doctorCertificate.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool isExperience()
        {
            if (doctorExperience.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool isSpecialization()
        {
            if (doctorSpecialization.Text != "")
            {
                return true;
            }
            return false;
        }
        private bool isSalary()
        {
            if (salaryTextBox.Text != "")
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
        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMainForm trigger = new AdminMainForm(UserID);
            trigger.Show();
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            userType.SelectedIndex = 0;
        }

        private void userType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (userType.SelectedValue.ToString() == "A")
            {
                cityTextBox.Enabled = true; buildingNoTextBox.Enabled = true; streetNameTextBox.Enabled = true; occupationTextBox.Enabled = true;
                maritalStateTextBox.Enabled = true; salaryTextBox.Enabled = true; doctorCertificate.Enabled = true; doctorSpecialization.Enabled = true;
                doctorExperience.Enabled = true;
                address.Enabled = true; cityNameLabel.Enabled = true; buildingNoLabel.Enabled = true; streetNameLabel.Enabled = true;
                occupation.Enabled = true; maritalSateLabel.Enabled = true; salary.Enabled = true; certificate.Enabled = true;
                Specialization.Enabled = true; experience.Enabled = true;
            }
            if (userType.SelectedValue.ToString() == "P")
            {
                cityTextBox.Enabled = true; buildingNoTextBox.Enabled = true; streetNameTextBox.Enabled = true; occupationTextBox.Enabled = true;
                maritalStateTextBox.Enabled = true; salaryTextBox.Enabled = false; doctorCertificate.Enabled = false; doctorSpecialization.Enabled = false;
                doctorExperience.Enabled = false;
                address.Enabled = true; cityNameLabel.Enabled = true; buildingNoLabel.Enabled = true; streetNameLabel.Enabled = true;
                occupation.Enabled = true; maritalSateLabel.Enabled = true; salary.Enabled = false; certificate.Enabled = false;
                Specialization.Enabled = false; experience.Enabled = false;
            }
            if (userType.SelectedValue.ToString() == "D")
            {
                cityTextBox.Enabled = false; buildingNoTextBox.Enabled = false; streetNameTextBox.Enabled = false; occupationTextBox.Enabled = false;
                maritalStateTextBox.Enabled = false; salaryTextBox.Enabled = true; doctorCertificate.Enabled = true; doctorSpecialization.Enabled = true;
                doctorExperience.Enabled = true;
                address.Enabled = false; cityNameLabel.Enabled = false; buildingNoLabel.Enabled = false; streetNameLabel.Enabled = false;
                occupation.Enabled = false; maritalSateLabel.Enabled = false; salary.Enabled = true; certificate.Enabled = true;
                Specialization.Enabled = true; experience.Enabled = true;
            }
            if (userType.SelectedValue.ToString() == "F")
            {
                cityTextBox.Enabled = false; buildingNoTextBox.Enabled = false; streetNameTextBox.Enabled = false; occupationTextBox.Enabled = false;
                maritalStateTextBox.Enabled = false; salaryTextBox.Enabled = false; doctorCertificate.Enabled = false; doctorSpecialization.Enabled = false;
                doctorExperience.Enabled = false;
                address.Enabled = false; cityNameLabel.Enabled = false; buildingNoLabel.Enabled = false; streetNameLabel.Enabled = false;
                occupation.Enabled = false; maritalSateLabel.Enabled = false; salary.Enabled = false; certificate.Enabled = false;
                Specialization.Enabled = false; experience.Enabled = false;
            }
            if (userType.SelectedValue.ToString() == "S")
            {
                cityTextBox.Enabled = false; buildingNoTextBox.Enabled = false; streetNameTextBox.Enabled = false; occupationTextBox.Enabled = false;
                maritalStateTextBox.Enabled = false; salaryTextBox.Enabled = true; doctorCertificate.Enabled = false; Specialization.Enabled = false;
                doctorExperience.Enabled = false;
                address.Enabled = false; cityNameLabel.Enabled = false; buildingNoLabel.Enabled = false; streetNameLabel.Enabled = false;
                occupation.Enabled = false; maritalSateLabel.Enabled = false; salary.Enabled = true; certificate.Enabled = false;
                Specialization.Enabled = false; experience.Enabled = false;
            }
            addressLabel.Visible = false; occupationLabel.Visible = false; maritalSateLabel.Visible = true; salaryLabel.Visible = false; certificateLabel.Visible = false; specializationLabel.Visible = false;
            experienceLabel.Visible = false;
        }

        private void buildingNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
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
            if (!isPassword())
            {
                passwordLabel.Visible = true;
            }
            else
            {
                passwordLabel.Visible = false;
            }
            if (!isConfirmPassword())
            {
                passwordConfirmationLabel.Visible = true;
            }
            else
            {
                passwordConfirmationLabel.Visible = false;
            }
            if (Convert.ToChar(userType.SelectedValue) == 'P' || Convert.ToChar(userType.SelectedValue) == 'A')
            {
                {
                    if (!isOccupation())
                    {
                        occupationLabel.Visible = true;
                    }
                    else
                    {
                        occupationLabel.Visible = false;
                    }
                    if (!isAdress())
                    {
                        addressLabel.Visible = true;
                    }
                    else
                    {
                        addressLabel.Visible = false;
                    }
                    if (Convert.ToChar(userType.SelectedValue) == 'A')
                    {
                        if (!isExperience())
                        {
                            experienceLabel.Visible = true;
                        }
                        else
                        {
                            experienceLabel.Visible = false;
                        }
                        if (!isSalary())
                        {
                            salaryLabel.Visible = true;
                        }
                        else
                        {
                            salaryLabel.Visible = false;
                        }
                        if (!isCertificate())
                        {
                            certificateLabel.Visible = true;
                        }
                        else
                        {
                            certificateLabel.Visible = false;
                        }
                        if (!isSpecialization())
                        {
                            specializationLabel.Visible = true;
                        }
                        else
                        {
                            specializationLabel.Visible = false;
                        }
                        if (isValidEmail() && isFirstName() && isLastName() && isPassword() && isConfirmPassword() && isValidPhone() && isAdress() && isOccupation() && isSalary() && isCertificate() && isSpecialization() && isExperience() && Convert.ToChar(userType.SelectedValue) == 'A')
                        {
                            KryptonMessageBox.Show("YOU CAN REGISTER NOW!!! ADMIN");
                            return;
                            //call ADMIN query/procedure
                        }
                    }
                    if (isValidEmail() && isFirstName() && isLastName() && isPassword() && isConfirmPassword() && isValidPhone() && isAdress() && isOccupation() && Convert.ToChar(userType.SelectedValue) == 'P')
                    {
                        KryptonMessageBox.Show("YOU CAN REGISTER NOW!!! PATIENT");
                        return;
                        //call Patient query/procedure
                    }
                }
            }
            if (Convert.ToChar(userType.SelectedValue) == 'S')
            {
                if (!isSalary())
                {
                    salaryLabel.Visible = true;
                }
                else
                {
                    salaryLabel.Visible = false;
                }
                if (isValidEmail() && isFirstName() && isLastName() && isPassword() && isConfirmPassword() && isValidPhone() && isSalary())
                {
                    KryptonMessageBox.Show("YOU CAN REGISTER NOW!!! SECRETARY");
                    return;
                    //call secretary query/procedure
                }
            }
            if (Convert.ToChar(userType.SelectedValue) == 'F')
            {
                KryptonMessageBox.Show("YOU CAN REGISTER NOW!!! PHARMACIST");
                return;
                //call Pharmacist query/procedure
            }
            if (Convert.ToChar(userType.SelectedValue) == 'D')
            {
                if (!isExperience())
                {
                    experienceLabel.Visible = true;
                }
                else
                {
                    experienceLabel.Visible = false;
                }
                if (!isSalary())
                {
                    salaryLabel.Visible = true;
                }
                else
                {
                    salaryLabel.Visible = false;
                }
                if (!isCertificate())
                {
                    certificateLabel.Visible = true;
                }
                else
                {
                    certificateLabel.Visible = false;
                }
                if (!isSpecialization())
                {
                    specializationLabel.Visible = true;
                }
                else
                {
                    specializationLabel.Visible = false;
                }
                if (isValidEmail() && isFirstName() && isLastName() && isPassword() && isConfirmPassword() && isValidPhone() && isSalary() && isCertificate() && isSpecialization() && isExperience() && Convert.ToChar(userType.SelectedValue) == 'D')
                {
                    KryptonMessageBox.Show("YOU CAN REGISTER NOW!!! DOCTOR");
                    return;
                    //call Doctor query/procedure
                }
            }
        }
    }
}
