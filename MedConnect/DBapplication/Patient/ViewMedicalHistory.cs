using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Patient
{

    public partial class ViewMedicalHistory : Form
    {
        readonly int UserID;
        public ViewMedicalHistory(int UserID)
        {
            this.UserID = UserID;
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMainForm frm = new PatientMainForm(UserID);
            frm.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void ViewMedicalHistory_Load(object sender, EventArgs e)
        {
            endDate.Value = DateTime.Now;
        }
    }
}
