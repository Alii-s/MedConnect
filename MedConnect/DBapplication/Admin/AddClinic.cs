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

namespace MedConnect.Admin
{
    public partial class AddClinic : Form
    {
        int UserID;
        AdminController Controller = new AdminController();
        public AddClinic(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMainForm form=new AdminMainForm(UserID);
            form.Show();
        }

        private void log_Out_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void AddClinic_Load(object sender, EventArgs e)
        {

        }
        private bool isValidPhone()
        {
            string phoneNumber = phoneNumberTextBox.Text.Trim();
            // Use a regular expression to check if the phone number is valid from egypt
            string phonePattern = @"^(01)\d{9}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
             
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    // If not a digit or a control key, suppress the key press
                    e.Handled = true;
                }
            
        }
        private void buildingNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }
        private bool isAdress()
        {
            if (cityTextBox.Text == "" || buildingNoTextBox.Text == "" || streetNameTextBox.Text == "")
            {
                return false;
            }
            return true;
        }
        private bool isOpening()
        {
            if (StartH.Text == "" || StartM.Text == "" || kryptonTextBox3.Text == "" || kryptonTextBox4.Text == "")
            {
                return false;
            }
            return true;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (!isValidPhone())
            {
                phoneNumberValidationLabel.Visible = true;
            }
            else
            {
                phoneNumberValidationLabel.Visible = false;
            }
            if (!isAdress())
            {
                addressLabel.Visible = true;
            }
            else
            {
                addressLabel.Visible = false;
            }
            if (!isOpening())
            {
                openlabel.Visible = true;
            }
            else
            {
                openlabel.Visible = false;
            }
            if (isValidPhone() && isAdress() && isOpening())
            {
                int t = Controller.AddClinic(phoneNumberTextBox.Text.ToString(), Convert.ToInt32(buildingNoTextBox.Text), streetNameTextBox.Text.ToString(), cityTextBox.Text.ToString(), Convert.ToInt16(StartH.Text), Convert.ToInt16(StartM.Text), Convert.ToInt16(kryptonTextBox3.Text), Convert.ToInt16(kryptonTextBox4.Text));

                if (t == 0)
                    KryptonMessageBox.Show("Error!! Clinic was not added");
                else
                    KryptonMessageBox.Show(" added successfully");
            }

        }

        private void StartH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                sh.Visible = true;
            }
            else
            sh.Visible=false;
        }

        private void StartM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                sm.Visible = true;
            }
            else
                sm.Visible=false;

        }

        private void kryptonTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                eh.Visible = true;
            }
            else
                eh.Visible=false;
        }

        private void kryptonTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                em.Visible = true;

            }
            else
                em.Visible=false;
        }
    }
}
