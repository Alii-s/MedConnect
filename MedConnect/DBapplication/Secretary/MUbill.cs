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
            DN.DataSource = dt1;
            DN.ValueMember = "UserID";
            DN.DisplayMember = "Lname";
            DataTable dt3 = secretaryController.SelectClinicLoc();
            CL.DataSource = dt3;
            CL.ValueMember = "ClinicID";
            CL.DisplayMember = "City";
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
            create_button.Visible = false;

        }

        private void Up_Click(object sender, EventArgs e)
        {
            int t;
            t = secretaryController.UpdateBill(Convert.ToInt32(PN.SelectedValue), UserID, Convert.ToInt32(DN.SelectedValue), Daate.Value, Convert.ToInt32(CL.SelectedValue), Convert.ToInt32(Price.Text), MofP.Text, IsPaid.Checked);
            if (t == 0)
            {
                KryptonMessageBox.Show(" Update was not successful ");
            }
            else
                KryptonMessageBox.Show(" Updated successfully ");
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the input is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the character
                plabel.Visible = true;
            }
            else
            {
                
                plabel.Visible = false;
            }


        }

        private void Cbill_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Up.Visible = false;
            create_button.Visible = true;
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            int t;
            t = secretaryController.CreateBill(Convert.ToInt32(PN.SelectedValue), UserID, Convert.ToInt32(DN.SelectedValue), Daate.Value, Convert.ToInt32(CL.SelectedValue), Convert.ToInt32(Price.Text), MofP.Text, IsPaid.Checked);
            if (t == 0)
            {
                KryptonMessageBox.Show(" Creation was not successful ");
            }
            else
                KryptonMessageBox.Show(" Created successfully ");
        }
    }
}
