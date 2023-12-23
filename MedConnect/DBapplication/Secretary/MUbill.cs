using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedConnect.Secertary;

namespace MedConnect.Secretary
{
    public partial class MUbill : Form
    {
        SecretaryController secretaryController =new SecretaryController();
        int UserID;
        public MUbill(int userID)
        {
            InitializeComponent();
            DataTable dt = secretaryController.SelectPatientsName();
            PN.DataSource= dt;
            PN.ValueMember = "UserID";
            PN.DisplayMember = "Lname";
            DataTable dt1 = secretaryController.SelectDoctorName();
            PN.DataSource = dt1;
            PN.ValueMember = "UserID";
            PN.DisplayMember = "Lname";
            DataTable dt3 = secretaryController.SelectClinicLoc();
            PN.DataSource = dt3;
            PN.ValueMember = "ClinicID";
            PN.DisplayMember = "City";
            UserID = userID;


        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Secretary form = new Secretary(UserID);
            form.Show();

        }

        private void log_Out_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void Ubill_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Up.Visible = true;

        }
    }
}
