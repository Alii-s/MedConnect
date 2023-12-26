using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedConnect.Patient
{
    public partial class Rating : Form
    {
        PatientController controller = new PatientController();
        int UserID;
        DataTable SessionInfo;
        public Rating(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            SessionInfo = controller.SelectSessionDates(UserID);
            sessionDate.DataSource = SessionInfo;
            sessionDate.DisplayMember = "Date";
            sessionDate.ValueMember = "Session_ID";
            sessionDate.DataSource = SessionInfo;
            if (SessionInfo != null)
            {
                sessionDate.SelectedIndex = 0;
            }
            kryptonDataGridView1.DataSource = controller.SelectDoctorRatings();
            ratingValue.DisplayMember= "Value";
            ratingValue.SelectedIndex = 0;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
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

        private void sessionDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(controller.SelectSessionDates(UserID)!=null)
                label5.Text = SessionInfo.Rows[sessionDate.SelectedIndex][2].ToString();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (controller.InsertRating(int.Parse(sessionDate.SelectedValue.ToString()),Comments.Text,int.Parse(ratingValue.Text), int.Parse(SessionInfo.Rows[sessionDate.SelectedIndex][3].ToString()),UserID) != 0)
            {
                KryptonMessageBox.Show("Rating Successful");
            }
            else
            {
                KryptonMessageBox.Show("Rating Not Successful");
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = controller.SelectDoctorRatings();
        }
    }
}
