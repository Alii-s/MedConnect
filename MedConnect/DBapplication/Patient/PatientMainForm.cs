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
            this.Close();
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

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMedicalHistory medHistory = new ViewMedicalHistory(UserID);
            medHistory.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating(UserID);
            rating.Show();
            this.Close();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills(UserID);
            bills.Show();
            this.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientReservation p = new PatientReservation(UserID);
            p.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password_Form form = new Change_Password_Form(UserID);
            form.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label2.Font.Style | FontStyle.Underline);
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label2.Font.Style & ~FontStyle.Underline);
            this.Cursor = Cursors.Default;
        }
    }
}
