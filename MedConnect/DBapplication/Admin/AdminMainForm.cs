using MedConnect.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Admin
{
    public partial class AdminMainForm : Form
    {
        int UserID;
        AdminController adminController = new AdminController();
        public AdminMainForm(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
            label1.Text +=" " + adminController.SelectName(UserID);

        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser addUser = new AddUser(UserID);
            addUser.Show();
        }
    }
}
