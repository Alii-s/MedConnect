using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Doctor.PatientsInfo
{
    public partial class DoctorPatientsInfo : Form
    {
        public DoctorPatientsInfo()
        {
            InitializeComponent();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorMainForm doctormainform = new DoctorMainForm();
            doctormainform.Show();
            this.Close();
            
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            DoctorMainForm doctormainform = new DoctorMainForm();
            doctormainform.Show();
            this.Close();
        }
    }
}
