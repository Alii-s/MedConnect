using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedConnect.Doctor
{
    public partial class DoctorsRatingTrendChart : Form
    {
        int userID;
        public DoctorsRatingTrendChart(int userid)
        {
            InitializeComponent();
            DisplayRatingsChart();
            userID = userid;
        }
        private void DisplayRatingsChart()
        {
           //IMPORTANT for me you should replace that procedure with a procedure that gets you average rating for each day
           //later when there are more populated data in database to be able to test the chart
            DataTable dt = new DoctorController().GetSessionRatingsWithComments();

            DataTable dtSelectedColumns = new DataTable();
            dtSelectedColumns.Columns.Add("Date"); 
            dtSelectedColumns.Columns.Add("Rating"); 
            foreach (DataRow row in dt.Rows)
            {
                DateTime dateTimeValue = (DateTime)row[0]; 
                string date = dateTimeValue.ToString("yyyy-MM-dd");
                int rating = Convert.ToInt32(row[2]); 
                dtSelectedColumns.Rows.Add(date, rating);
            }

            DataTable ratingsData = dtSelectedColumns;

            Chart ratingsChart = chart1; 
            ratingsChart.Series.Clear();
            ratingsChart.Titles.Clear();
            ratingsChart.Titles.Add("Ratings Bar Chart");

          
            Series series = new Series("Ratings");
            series.ChartType = SeriesChartType.Bar;

           
            foreach (DataRow row in ratingsData.Rows)
            {
                string date = row["Date"].ToString(); 
                int rating = Convert.ToInt32(row["Rating"]); 
                series.Points.AddXY(date, rating);
            }


            ratingsChart.Series.Add(series);

           
            series.Color = Color.Blue; 
            series.BorderWidth = 1; 

      
            ratingsChart.ChartAreas[0].AxisX.Interval = 1; 
            ratingsChart.ChartAreas[0].AxisX.Title = "Date";
            ratingsChart.ChartAreas[0].AxisY.Title = "Avg Rating";

     
            ratingsChart.Dock = DockStyle.Fill; 
        }

        private void DoctorsRatingTrendChart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            DoctorRating_Comments chart = new DoctorRating_Comments(userID);
            chart.Show();
            this.Hide();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
