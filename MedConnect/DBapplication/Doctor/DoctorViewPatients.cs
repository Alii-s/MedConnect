using MedConnect.Doctor.PatientsInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Doctor
{
    
    public partial class DoctorViewPatients : Form
    {
        int UserId;
        DoctorController doctorController = new DoctorController();
        public void ResetPatientsTable()
        {

            DataTable dataTable = doctorController.SelectAllPatients();
            kryptonDataGridView1.DataSource = dataTable;
            kryptonDataGridView1.Refresh();

        }
        public DoctorViewPatients(int userid)
        {
            UserId = userid;
            InitializeComponent();
            ResetPatientsTable();
            DataTable dataTable = doctorController.SelectAllPatients();
            kryptonDataGridView1.DataSource = dataTable;
            kryptonDataGridView1.Refresh();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            DoctorMainForm doctormainform = new DoctorMainForm(UserId, 0);
            doctormainform.Show();
            this.Close();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
       
                if (int.TryParse(kryptonDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out int patientId))
                {
                    DoctorDiagnosisSession doctorDiagnosticSessions = new DoctorDiagnosisSession(UserId, patientId);
                    doctorDiagnosticSessions.Show();
                    this.Close();
                }
                else
                {
        
                    MessageBox.Show("Invalid Patient ID");
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            string fullName = firstNameTextBox.Text;
            string phoneNumber = kryptonTextBox1.Text;
            string[] names = fullName.Split(' ');

            DataTable dataTable;

            // Check if names array has at least two elements
            if (names.Length >= 2 && !string.IsNullOrEmpty(phoneNumber))
            {
                string firstName = names[0];
                string lastName = names[1];
                dataTable = doctorController.SelectAllPatientsWithFilter(firstName, lastName, phoneNumber);
            }
            else if (names.Length >= 2 && string.IsNullOrEmpty(phoneNumber))
            {
                string firstName = names[0];
                string lastName = names[1];
                dataTable = doctorController.SelectAllPatientsWithNameFilter(firstName, lastName);
            }
            else if (names.Length < 2 && !string.IsNullOrEmpty(phoneNumber))
            {
                dataTable = doctorController.SelectAllPatientsWithPhoneFilter(phoneNumber);
            }
            else
            {
                dataTable = doctorController.SelectAllPatients();
            }

            kryptonDataGridView1.DataSource = dataTable;
            kryptonDataGridView1.Refresh();
        }


        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
            {
                // If it's the first character or after a space, convert it to uppercase
                if (firstNameTextBox.SelectionStart == 0 || (firstNameTextBox.SelectionStart > 0 && firstNameTextBox.Text[firstNameTextBox.SelectionStart - 1] == ' '))
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
                // If it's not the first character and not after a space, convert it to lowercase
                else
                {
                    e.KeyChar = char.ToLower(e.KeyChar);
                }
            }
            // If it's not a letter or space, allow Backspace
            else if (e.KeyChar != (char)Keys.Back)
            {
                // Suppress the key press
                e.Handled = true;
            }
        }

        private void kryptonTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
