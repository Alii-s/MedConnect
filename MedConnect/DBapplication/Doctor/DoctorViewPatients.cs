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
        DoctorController doctorController = new DoctorController();
        public DoctorViewPatients()
        {
            InitializeComponent();
            DataTable dataTable = doctorController.SelectAllPatients();



            kryptonDataGridView1.DataSource = dataTable;
            kryptonDataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorPatientsInfo DoctorPatientsinfo = new DoctorPatientsInfo();
            DoctorPatientsinfo.Show();
            this.Close();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }
    }
}
