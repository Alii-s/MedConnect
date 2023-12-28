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
    public partial class DiagnosisSessions : Form
    {
        int UserID;
        DoctorController controller = new DoctorController();
        public DiagnosisSessions(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DoctorMainForm doctormainform = new DoctorMainForm(UserID, 0);
            doctormainform.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = controller.SelectPatientRecords();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = controller.SelectSessions();
        }

        private void closeApplication_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DoctorMainForm f = new DoctorMainForm(UserID,0);
            f.Show();
        }

        private void logOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Trigger trigger1 = new Trigger();
            trigger1.Show();
        }
    }
}
