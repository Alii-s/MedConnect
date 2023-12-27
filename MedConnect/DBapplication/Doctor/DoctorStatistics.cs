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

namespace MedConnect.Doctor
{
    public partial class DoctorStatistics : Form
    {
        int doctorId;
        DoctorController doctorController = new DoctorController();
        public DoctorStatistics(int doctorId)
        {
            InitializeComponent();
          //  Refresh();
            this.doctorId = doctorId;
        }

        private void Refresh()
        {
            // Ensure fromDate is not in the future
            if (fromDate.Value > DateTime.Now)
            {
                MessageBox.Show("From date cannot be in the future.", "Invalid Date");
                return;
            }

            // Ensure toDate is not in the future and is at least one day after fromDate
            if (toDate.Value > DateTime.Now || toDate.Value <= fromDate.Value)
            {
                MessageBox.Show("To date must be at least one day after the from date and cannot be in the future.", "Invalid Date");
                return;
            }

            toDate.MinDate = fromDate.Value.AddDays(1);
            toDate.MaxDate = DateTime.Now;
            fromDate.MaxDate = DateTime.Now;

            DataTable dt = doctorController.GetMostRepeatedTypeInDiagnosisSessions(DateTime.Parse(fromDate.Value.ToString()), DateTime.Parse(toDate.Value.ToString()));
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    revenueTextBox.Text = dt.Rows[0][0].ToString();
                    kryptonTextBox1.Text = dt.Rows[0][1].ToString();
                }
            }
            else
            {
                revenueTextBox.Text = "Sorry No sufficient data";
                kryptonTextBox1.Text = "";
            }

            kryptonTextBox1.Refresh();
            revenueTextBox.Refresh();
            handlingChart();
        }


        private void revenueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            toDate.MinDate = fromDate.Value;
            toDate.MaxDate = DateTime.Now;
            fromDate.MaxDate = DateTime.Now;


            Refresh();
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {
            toDate.MinDate = fromDate.Value;
            toDate.MaxDate = DateTime.Now;
            fromDate.MaxDate = DateTime.Now;

            Refresh();
        }

        private void handlingChart()
        {
            DataTable dt = doctorController.CountRepeatedDatesInDiagnosisSession();


            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data available for the chart.", "Data Error");
               DataTable dt1 = new DataTable();
                dt1.Columns.Add("Date", typeof(DateTime));
                dt1.Columns.Add("Count", typeof(int));
                for (int i = 0; i < chart1.Series["Series1"].Points.Count; i++)
                {
                    dt1.Rows.Add(DateTime.Now, 0);
                }
                chart1.DataSource = dt1;
                chart1.Series["Series1"].XValueMember = "Date";
                chart1.Series["Series1"].YValueMembers = "Count";
                chart1.DataBind();
                return;
            }
            dt.Columns.Add("FormattedDate", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                if (dt.Columns.Contains("FormattedDate"))
                {
                    row["FormattedDate"] = ((DateTime)row["Date"]).ToString("MM/dd/yyyy");
                }
            }
            chart1.DataSource = dt;
                chart1.Series["Series1"].XValueMember = "FormattedDate";
                chart1.Series["Series1"].YValueMembers = "Count";
                chart1.DataBind();

     
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            //chart1
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorMainForm doctorMainForm = new DoctorMainForm(doctorId, 0);
            doctorMainForm.Show();
            this.Close();
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
    }
}
