using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace MedConnect.Patient
{

    public partial class ViewMedicalHistory : Form
    {
        readonly int UserID;
        PatientController controller = new PatientController();
        public ViewMedicalHistory(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
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

        private void ViewMedicalHistory_Load(object sender, EventArgs e)
        {
            endDate.Value = DateTime.Today;
            startDate.Value = DateTime.Today.AddYears(-1);
            kryptonDataGridView1.DataSource = controller.GetSessionInfo(UserID,startDate.Value,endDate.Value);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (startDate.Value == DateTime.Today)
            {
                KryptonMessageBox.Show("Please choose a start date that is not today's date.");
                return;
            }

            if (endDate.Value < startDate.Value)
            {
                KryptonMessageBox.Show("End date cannot be before the start date.");
                return;
            }
            KryptonMessageBox.Show($"Filtering data from {startDate.Value.ToShortDateString()} to {endDate.Value.ToShortDateString()}");
            kryptonDataGridView1.DataSource = controller.GetSessionInfo(UserID, startDate.Value, endDate.Value);
            foreach (DataGridViewColumn column in kryptonDataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1; 
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = controller.SelectPatientRecords(UserID);
            foreach (DataGridViewColumn column in kryptonDataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1;
            }
        }
    }
}
