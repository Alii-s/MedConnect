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
    public partial class ClinicStatistics : Form
    {
        int UserID;
        public ClinicStatistics(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void ClinicStatistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet2.DataTable1);
            // TODO: This line of code loads data into the 'dataSet1.SessionClinic' table. You can move, or remove it, as needed.
            this.sessionClinicTableAdapter.Fill(this.dataSet1.SessionClinic);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMainForm form = new AdminMainForm(UserID);
            form.Show();
        }

        private void log_Out_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }
    }
}
