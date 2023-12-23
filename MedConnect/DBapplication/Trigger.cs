using ComponentFactory.Krypton.Toolkit;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect
{
    public partial class Trigger : Form
    {
        Controller LoginController = new Controller();
        public Trigger()
        {
            InitializeComponent();
        }
            private void closeApplication_Click(object sender, EventArgs e)
        {

        }

        private void closeApplication_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            emailTextBox.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            passwordTextBox.Focus();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label2.Font.Style | FontStyle.Underline);
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label2.Font.Style & ~FontStyle.Underline);
            this.Cursor= Cursors.Default;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = LoginController.Login(emailTextBox.Text, passwordTextBox.Text);
            if(dataTable == null)//if the datatable is null meaning that the data isnt present in the database
            {
                errorMsg.Visible = true;
                return;
            }
            string UserIDS = dataTable.Rows[0][3].ToString();
            int UserID = int.Parse(UserIDS); //Extracting the ID
            string UserTypeS = dataTable.Rows[0][2].ToString();
            char UserType = char.Parse(UserTypeS); //Extracting the character
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
                DoctorMainForm form = new DoctorMainForm(UserID);
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
            else if(UserType == 'S')
            {
                this.Hide();
                Secretary.Secretary form = new Secretary.Secretary(UserID);
                form.Show();
                return;
            }
            else
            {
                //this.Hide();
                //AdminMainForm form = new AdminMainForm(UserID);
                //form.Show();
                //return;
            }
        }
    }
}
