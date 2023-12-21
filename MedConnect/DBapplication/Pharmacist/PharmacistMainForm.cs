using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Pharmacist
{
    public partial class PharmacistMainForm : Form
    {
        readonly int UserID;
        PharmacistController controller;
        public PharmacistMainForm(int UserID)
        {
            InitializeComponent();
            controller = new PharmacistController();
            this.UserID = UserID;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void PharmacistMainForm_Load(object sender, EventArgs e)
        {
            label1.Text += " " + controller.getPharmacistName(UserID).ToString();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
