using MedConnect.Admin;
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
    public partial class DoctorMainForm : Form
    {
        int UserId;
        public DoctorMainForm(int UserId,int IsAdmin)
        {
            this.UserId = UserId;
            InitializeComponent();
            if(IsAdmin == 1) { Switch_interface.Visible = true; }
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            DoctorViewPatients doctorViewPatients = new DoctorViewPatients(UserId);
            doctorViewPatients.Show();
            this.Hide();
            
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            DoctorScheuale doctorScheuale = new DoctorScheuale(UserId);
            doctorScheuale.Show();
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ClinicsAppointments clinicsAppointments = new ClinicsAppointments(UserId);
            clinicsAppointments.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DoctorRating_Comments doctorRating_Comments = new DoctorRating_Comments(UserId);
            doctorRating_Comments.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password_Form form = new Change_Password_Form(UserId);
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

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            DoctorStatistics doctorStatistics = new DoctorStatistics(UserId);
            doctorStatistics.Show();
            this.Hide();
        }

        private void Switch_interface_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMainForm form = new AdminMainForm(UserId);
            form.Show();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {

            DiagnosisSessions f = new DiagnosisSessions(UserId);
            f.Show();
            this.Close();
        }
    }
}
