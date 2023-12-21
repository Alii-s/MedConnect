using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Patient
{
    public partial class PatientMainForm : Form
    {
        readonly int UserID;
        PatientController controller= new PatientController();
        public PatientMainForm(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Info patient_Info = new Patient_Info(UserID);
            patient_Info.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientMainForm_Load(object sender, EventArgs e)
        {
            label1.Text +=" "+ controller.SelectPatientName(UserID).ToString();
        }
    }
}
