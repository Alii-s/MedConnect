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
            controllerObj.InsertIntoPrescription(sessionID, Convert.ToInt32(kryptonComboBox1.SelectedValue),int.Parse( kryptonTextBox1.Text), Convert.ToInt32(kryptonTextBox2.Text), kryptonTextBox3.Text);
            MessageBox.Show("Prescription Added Successfully");
            this.Close();
            DoctorMainForm form = new DoctorMainForm(DoctorID);
            form.Show();
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
    }
}
