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
            DoctorMainForm doctormainform = new DoctorMainForm(UserId);
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
            string[] names = fullName.Split(' ');

            // Check if names array has at least two elements
            if (names.Length >= 2)
            {
                string firstName = names[0];
                string lastName = names[1];         
                DataTable dataTable = doctorController.SelectAllPatientsWithFilter(firstName, lastName, kryptonTextBox1.Text);
                kryptonDataGridView1.DataSource = dataTable;
                kryptonDataGridView1.Refresh();
            }
           
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
    }
}
