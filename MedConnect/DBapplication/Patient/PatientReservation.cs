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

namespace MedConnect.Patient
{
    public partial class PatientReservation : Form
    {
        int UserID;
        PatientController PatientController = new PatientController();
        DataTable clinicInfo;
        DataTable ReservationList;
        DataTable PatientReservations;
        public PatientReservation(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            clinicInfo = PatientController.SelectClinicCities();
            clinicCity.DisplayMember = "City";
            clinicCity.ValueMember = "ClinicID";
            clinicCity.DataSource = clinicInfo;
            reservationDate.MinDate = DateTime.Today.AddDays(+1);
            reservationDate.MaxDate = DateTime.Today.AddMonths(1);
            reservationDate.Value = DateTime.Today.AddDays(1);
            typeBox.DisplayMember = "Value";
            typeBox.SelectedIndex = 0;
            ReservationList = PatientController.GetReservationList();
            PatientReservations = PatientController.GetPatientReservations(UserID, DateTime.Today);
            kryptonDataGridView1.DataSource = PatientReservations;
            reservationID.DisplayMember = "ReservationID";
            reservationID.ValueMember = "ReservationID";
            reservationID.DataSource = PatientController.GetPatientReservations(UserID,DateTime.Today);
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

        private void clinicCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = clinicInfo.Rows[clinicCity.SelectedIndex][2].ToString();
            TimeSpan openingTime = (TimeSpan)clinicInfo.Rows[clinicCity.SelectedIndex][3]; //parsing opening time
            TimeSpan closingTime = (TimeSpan)clinicInfo.Rows[clinicCity.SelectedIndex][4];
            
            List<TimeSpan> timeSlots = new List<TimeSpan>();
            TimeSpan currentTime = openingTime;
            while (currentTime <= closingTime)
            {
                timeSlots.Add(currentTime);
                currentTime = currentTime.Add(new TimeSpan(0, 30, 0));
            }
            timeList.DataSource = timeSlots;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (ReservationList != null)
            {
                for (int i = 0; i <= ReservationList.Rows.Count - 1; i++)
                {
                    TimeSpan Time = (TimeSpan)ReservationList.Rows[i][0];
                    DateTime Dates = (DateTime)ReservationList.Rows[i][1];
                    int cityID = (int)ReservationList.Rows[i][2];
                    if ((TimeSpan)timeList.SelectedValue == Time && reservationDate.Value == Dates && (int)clinicCity.SelectedValue == cityID)
                    {
                        KryptonMessageBox.Show("There is a confirmed Reservation at that time");
                        return;
                    }
                }
            }
            if (PatientReservations != null)
            {
                for (int i = 0; i <= PatientReservations.Rows.Count - 1; i++)
                {
                    if ((TimeSpan)timeList.SelectedValue == (TimeSpan)PatientReservations.Rows[i][2] && (DateTime)reservationDate.Value == (DateTime)PatientReservations.Rows[i][3])
                    {
                        KryptonMessageBox.Show("You Have an Reservation request at that time");
                        return;
                    }
                }
            }
            PatientController.InsertReservation((DateTime)reservationDate.Value, typeBox.Text, (TimeSpan)timeList.SelectedValue, (int)clinicCity.SelectedValue, UserID);
            kryptonDataGridView1.DataSource = PatientController.GetPatientReservations(UserID, DateTime.Today);
            reservationID.DataSource = PatientController.GetPatientReservations(UserID, DateTime.Today);
            KryptonMessageBox.Show("Reserved Successfully");
            ReservationList = PatientController.GetReservationList();
            PatientReservations = PatientController.GetPatientReservations(UserID, DateTime.Today);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            PatientController.CancelReservation(int.Parse(reservationID.Text));
            kryptonDataGridView1.DataSource = PatientController.GetPatientReservations(UserID, DateTime.Today);
            reservationID.DataSource = PatientController.GetPatientReservations(UserID, DateTime.Today);
            KryptonMessageBox.Show("Cancelled Successfully");
        }
    }
}
