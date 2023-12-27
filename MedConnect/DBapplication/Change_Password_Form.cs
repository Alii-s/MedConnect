using ComponentFactory.Krypton.Toolkit;
using MedConnect.Admin;
using MedConnect.Doctor;
using MedConnect.Patient;
using MedConnect.Pharmacist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedConnect
{
    public partial class Change_Password_Form : Form
    {
        readonly int UserID;
        Controller myController;

        public Change_Password_Form(int UserID)
        {
            InitializeComponent();

            this.UserID = UserID;
            myController = new Controller();

            currentPasswordTextBox.UseSystemPasswordChar = true;
            newPasswordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            currentPasswordLabel.Visible = false;
            newPasswordLabel.Visible = false;
            confirmPasswordLabel.Visible = false;

            if (currentPasswordTextBox.Text.Length == 0)
            {
                currentPasswordLabel.Text = "Enter current password";
                currentPasswordLabel.Visible = true;
                return;
            }

            if (newPasswordTextBox.Text.Length == 0)
            {
                newPasswordLabel.Text = "Enter new password";
                newPasswordLabel.Visible = true;
                return;
            }

            if (confirmPasswordTextBox.Text.Length == 0)
            {
                confirmPasswordLabel.Text = "Confirm password";
                confirmPasswordLabel.Visible = true;
                return;
            }

            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                confirmPasswordLabel.Text = "Password mismatch";
                confirmPasswordLabel.Visible = true;
                return;
            }

            string queryResult = Convert.ToString(myController.checkPassword(UserID, currentPasswordTextBox.Text));

            if (queryResult == "False") 
            {
                currentPasswordLabel.Text = "Incorrect password";
                currentPasswordLabel.Visible = true;
                return;
            }
            
            int passwordChanged = myController.changePassword(UserID, newPasswordTextBox.Text);

            if (passwordChanged == 0)
            {
                KryptonMessageBox.Show("Password change failed", "ERROR");
                return;
            }
            else
            {
                KryptonMessageBox.Show("Password changed successfully", "Success");
                currentPasswordTextBox.Text = string.Empty;
                newPasswordTextBox.Text = string.Empty;
                confirmPasswordTextBox.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char UserType = Convert.ToChar(myController.getUserType(UserID));

            if (UserType == 'P')
            {
                this.Hide();
                PatientMainForm form = new PatientMainForm(UserID);
                form.Show();
                return;
            }
            else if (UserType == 'D')
            {
                this.Hide();
                DoctorMainForm form = new DoctorMainForm(UserID, 0);
                form.Show();
                return;
            }
            else if (UserType == 'F')
            {
                this.Hide();
                Pharmacist_Main_Form form = new Pharmacist_Main_Form(UserID);
                form.Show();
                return;
            }
            else if (UserType == 'S')
            {
                this.Hide();
                Secretary.Secretary form = new Secretary.Secretary(UserID);
                form.Show();
                return;
            }
            else if ((UserType == 'A'))
            {
                this.Hide();
                AdminMainForm form = new AdminMainForm(UserID);
                form.Show();
                return;
            }
        }

        private void kryptonCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            currentPasswordTextBox.UseSystemPasswordChar = !currentPasswordTextBox.UseSystemPasswordChar;
        }

        private void kryptonCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            newPasswordTextBox.UseSystemPasswordChar = !newPasswordTextBox.UseSystemPasswordChar;
        }

        private void kryptonCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            confirmPasswordTextBox.UseSystemPasswordChar = !confirmPasswordTextBox.UseSystemPasswordChar;
        }

        private void currentPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changePasswordButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void newPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changePasswordButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void confirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changePasswordButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
