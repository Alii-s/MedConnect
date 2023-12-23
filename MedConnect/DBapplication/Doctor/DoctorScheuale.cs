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
    public partial class DoctorScheuale : Form
    {
        int UserId;
        DoctorController controllerObj = new DoctorController();
        public DoctorScheuale(int userid)
        {
            UserId = userid;
            InitializeComponent();
            HandlingComboxesValues();
            kryptonDataGridView1.DataSource = controllerObj.GetDoctorSchedule(UserId);
        }

        #region HandlingComboxesValues
        private void HandlingComboxesValues()
        {

            //show Clincs City in combox
            kryptonComboBox1.DataSource = controllerObj.SelectAllClinicData();
            kryptonComboBox1.DisplayMember = "City";
            kryptonComboBox1.ValueMember = "ClinicID";

            string SelectedCity = kryptonComboBox1.Text;

            //show days in combox
            string[] daysOfWeek = Enum.GetNames(typeof(DayOfWeek));
            kryptonComboBox2.DataSource = daysOfWeek;
            kryptonComboBox2.DisplayMember = "Day";
      



           
        }

        int closingHour;
        public void ResetingTimeBasedOnCity() {
            if (kryptonComboBox1.Text == "")
            {
                return;
            }
            else
            {
                DataTable clinicData = controllerObj.SelectAllClinicData();

                DataRow[] selectedRows = clinicData.Select("City = '" + kryptonComboBox1.Text + "'");

                if (selectedRows.Length > 0)
                {
                    TimeSpan openTime = (TimeSpan)selectedRows[0].ItemArray.ElementAt(5);
                    TimeSpan closeTime = (TimeSpan)selectedRows[0].ItemArray.ElementAt(6);

                    // Assuming openTime and closeTime are TimeSpan variables that hold the opening and closing times
                    int openingHour = openTime.Hours;
                    closingHour = closeTime.Hours;

                    // Create a list to hold the hours
                    List<string> hours = new List<string>();

                    // Add the hours in the range between the opening time and closing time
                    for (int i = openingHour; i <= closingHour; i++)
                    {
                        hours.Add(i.ToString());
                    }

                    // Set the DataSource, DisplayMember, and ValueMember properties of the ComboBoxes
                    kryptonComboBox3.DataSource = new List<string>(hours);
                    kryptonComboBox3.DisplayMember = "Time";

                   

                }
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetingTimeBasedOnCity();
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> hours = new List<string>();
            int openingHour = int.Parse(kryptonComboBox3.Text.Trim())+1;
            for (int i = openingHour; i <= closingHour; i++)
            {
                hours.Add(i.ToString());
            }
            kryptonComboBox4.DataSource = new List<string>(hours);
            kryptonComboBox4.DisplayMember = "Time";

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (CheckThatnoParallelScheualding())
            {
                controllerObj.AddDoctorSchedule(UserId, int.Parse(kryptonComboBox1.SelectedValue.ToString()), kryptonComboBox2.Text, int.Parse(kryptonComboBox3.Text), int.Parse(kryptonComboBox4.Text));
                DataTable dataTable = controllerObj.GetDoctorSchedule(UserId);
                kryptonDataGridView1.DataSource = dataTable;
                kryptonDataGridView1.Refresh();
            }
          
              
            
        }

        private bool CheckThatnoParallelScheualding()
        {
            DataTable dataTableOfScheualesAtthatday = controllerObj.GetDayAtSchedule(UserId, kryptonComboBox2.Text);
            if(dataTableOfScheualesAtthatday == null)
            {
                return true;
            }
            if ( dataTableOfScheualesAtthatday.Rows.Count > 0)
            {
                for (int i = 0; i < dataTableOfScheualesAtthatday.Rows.Count; i++)
                {
                    TimeSpan StarttimeSpanAlready = (TimeSpan)dataTableOfScheualesAtthatday.Rows[i].ItemArray.ElementAt(0);
                    TimeSpan endtimeSpanAlready = (TimeSpan)dataTableOfScheualesAtthatday.Rows[i].ItemArray.ElementAt(1);
                    int StarttimeSpanAlreadyRegistered = (int)StarttimeSpanAlready.TotalHours;
                    int endtimeSpanAlreadyRegistered = (int)endtimeSpanAlready.TotalHours;
              
          
                    if (int.Parse(kryptonComboBox3.Text) >= StarttimeSpanAlreadyRegistered && int.Parse(kryptonComboBox3.Text) <= endtimeSpanAlreadyRegistered)
                    {
                        MessageBox.Show("You have a scheuale at that time");
                        return false;
                    }
                    else if (int.Parse(kryptonComboBox4.Text) >= StarttimeSpanAlreadyRegistered && int.Parse(kryptonComboBox4.Text) <= endtimeSpanAlreadyRegistered)
                    {
                        MessageBox.Show("You have a scheuale at that time");
                        return false;
                    }
                    else if (int.Parse(kryptonComboBox3.Text) <= StarttimeSpanAlreadyRegistered && int.Parse(kryptonComboBox4.Text) >= endtimeSpanAlreadyRegistered)
                    {
                        MessageBox.Show("You have a scheuale at that time");
                        return false;
                    }
                }
            }
                return true;
            
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            controllerObj.DeleteDoctorSchedule(UserId, int.Parse(kryptonComboBox1.SelectedValue.ToString()), kryptonComboBox2.Text);

            DataTable dataTable = controllerObj.GetDoctorSchedule(UserId);
            kryptonDataGridView1.DataSource = dataTable;
            kryptonDataGridView1.Refresh();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorMainForm doctormainform = new DoctorMainForm(UserId);
            doctormainform.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }
    }
}
