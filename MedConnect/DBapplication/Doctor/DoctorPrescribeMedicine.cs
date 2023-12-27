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
    public partial class DoctorPrescribeMedicine : Form
    {
        int sessionID;
        int DoctorID;
        DoctorController controllerObj = new DoctorController();
        public DoctorPrescribeMedicine(int sessionID, int doctorID)
        {
            InitializeComponent();
            this.sessionID = sessionID;
            DataTable dt = controllerObj.GetActiveNonExpiredMedicines();
            kryptonComboBox1.DataSource = dt;
            kryptonComboBox1.DisplayMember = "Medicine_Name";
            kryptonComboBox1.ValueMember = "MedicineID";
            DoctorID = doctorID;
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(kryptonComboBox1.SelectedValue.ToString(), out int medicineId) &&
                int.TryParse(kryptonTextBox1.Text, out int quantity) &&
                int.TryParse(kryptonTextBox2.Text, out int dosage) &&
                !string.IsNullOrEmpty(kryptonTextBox3.Text))
            {
                controllerObj.InsertIntoPrescription(sessionID, medicineId, quantity, dosage, kryptonTextBox3.Text);
                MessageBox.Show("Prescription Added Successfully");
                this.Close();
                DoctorMainForm form = new DoctorMainForm(DoctorID, 0);
                form.Show();
            }
            else
            {
                MessageBox.Show("Please ensure all fields are correctly filled.");
            }
        }


        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorDiagnosisSession doctorDiagnosisSession = new DoctorDiagnosisSession(DoctorID, sessionID);
            doctorDiagnosisSession.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
