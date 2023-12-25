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
    public partial class Medicine_Prescription_Statistics_Form : Form
    {
        readonly int UserID;
        PharmacistController controller;

        public Medicine_Prescription_Statistics_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            controller = new PharmacistController();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Pharmacist_Main_Form form = new Pharmacist_Main_Form(UserID);
            form.Show();
        }

        private void Medicine_Prescription_Statistics_Form_Load(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = controller.getMostPrescripedMedicine();
            kryptonDataGridView1.Refresh();
        }
    }
}
