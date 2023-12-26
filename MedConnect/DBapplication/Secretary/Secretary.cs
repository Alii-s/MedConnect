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
    public partial class Secretary : Form
    {
        int UserID;
        SecretaryController secretaryController = new SecretaryController();
        public Secretary(int userID)
        {
            InitializeComponent();
            UserID = userID;

            string t = secretaryController.GetSecName(UserID).ToString(); 
           label2.Text = t;
            // Name.Refresh();
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateSecretaryInfo f = new UpdateSecretaryInfo(UserID);
            f.Show();
          

        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewPatient_Click(object sender, EventArgs e)
        {
            this.Close();
            Register form = new Register(1);
            form.Show();
        }

        private void UPatientInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdatePatientSec form = new UpdatePatientSec(UserID);
            form.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void Reservations_Click(object sender, EventArgs e)
        {

        }

        private void MUbill_Click(object sender, EventArgs e)
        {
            this.Close();
            MUbill form = new MUbill(UserID);
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password_Form form = new Change_Password_Form(UserID);
            form.Show();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
            this.Cursor = Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Underline);
            this.Cursor = Cursors.Default;
        }
    }
}
 