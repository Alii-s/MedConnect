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
    public partial class Bills : Form
    {
        int UserID;
        PatientController PatientController = new PatientController();
        public Bills(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMainForm frm = new PatientMainForm(UserID);
            frm.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            diagnosisBills.DataSource = PatientController.SelectDiagnosisBills(UserID);
            DeliveryBills.DataSource = PatientController.GetDeliveryBills(UserID);

        }
    }
}
