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
    public partial class ClinicsAppointments : Form
    {
        DoctorController controllerObj = new DoctorController();
        public ClinicsAppointments()
        {
            InitializeComponent();
            //show Clincs City in combox
            kryptonComboBox1.DataSource = controllerObj.SelectAllClinicData();
            kryptonComboBox1.DisplayMember = "City";
            kryptonComboBox1.ValueMember = "ClinicID";

        }

        private void ClinicsAppointments_Load(object sender, EventArgs e)
        {

        }

      
        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryptonComboBox1.SelectedValue != null && int.TryParse(kryptonComboBox1.SelectedValue.ToString(), out int clinicid))
            {
                DataTable dt = controllerObj.GetActiveReservationsWithDate(clinicid, DateTime.Now);
                kryptonDataGridView1.DataSource = dt;
                kryptonDataGridView1.Refresh();
            }
        }

    

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
