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

namespace MedConnect.Admin
{
    public partial class RemoveUser : Form
    {
        AdminController adminController = new AdminController();
        int UserID;
        public RemoveUser(int userID)
        {
            InitializeComponent();
            DataTable dt = adminController.SelectEmail();
            Email.DataSource = dt;
            Email.ValueMember = "UserID";
            Email.DisplayMember = "Email";

            UserID = userID;
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_Out_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin.AdminMainForm form = new AdminMainForm(UserID);
            form.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int t= adminController.RemoveUser(Convert.ToInt32(Email.SelectedValue));
            if(t == 0) { KryptonMessageBox.Show(" Error!! User was not removed "); }
            else
            {
                KryptonMessageBox.Show("User was removed successfully");
            }
            DataTable dt = adminController.SelectEmail();
            Email.DataSource = dt;
            Email.ValueMember = "UserID";
            Email.DisplayMember = "Email";
        }
    }
}
