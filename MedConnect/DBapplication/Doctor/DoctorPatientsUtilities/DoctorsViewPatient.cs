using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Doctor.DoctorPatientsInfo
{
    public partial class DoctorsViewPatient : Form
    {
        public DoctorsViewPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   DoctorPatientsInfo doctorPatientsInfo = new DoctorPatientsInfo();
          //  doctorPatientsInfo.Show();
            this.Close();
        }
    }
}
