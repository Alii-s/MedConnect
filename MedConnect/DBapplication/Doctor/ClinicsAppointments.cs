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
    public partial class ClinicsAppointments : Form
    {
        int UserID  ;
        DoctorController controllerObj = new DoctorController();
        DateTime SelectedDate = DateTime.Now;
        public ClinicsAppointments(int userID)
        {
            InitializeComponent();
            //show Clincs City in combox
            kryptonComboBox1.DataSource = controllerObj.SelectAllClinicData();
            kryptonComboBox1.DisplayMember = "City";
            kryptonComboBox1.ValueMember = "ClinicID";
            UserID = userID;
        }

        private void ClinicsAppointments_Load(object sender, EventArgs e)
        {

        }

      
        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

    

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshTable()
        {
            kryptonDataGridView1.DataSource = null;
            kryptonDataGridView1.Refresh();
            bool isSelected1 = kryptonCheckButton1.Checked;
            bool isSelected2 = kryptonCheckButton2.Checked;
            bool isSelected3 = kryptonCheckButton3.Checked;
            
            if (kryptonComboBox1.SelectedValue != null && int.TryParse(kryptonComboBox1.SelectedValue.ToString(), out int clinicid))
            {
                DataTable dt = new DataTable();

                if (isSelected1 && isSelected2 && isSelected3)
                {
                    var dt1 = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate.AddDays(-1));
                    var dt2 = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate.AddDays(1));
                    var dt3 = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate);

                    if (dt1 != null)
                        dt.Merge(dt1);

                    if (dt2 != null)
                        dt.Merge(dt2);

                    if (dt3 != null)
                        dt.Merge(dt3);
                }
                else if (isSelected1 && isSelected2)
                {
                    var dtt= controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate);
                    if (dtt != null)
                    dt.Merge(dtt);
                    var dt1 = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate.AddDays(-1));

                    if (dt1 != null)
                        dt.Merge(dt1);
                }
                else if (isSelected1 && isSelected3)
                {
                    var dtt= controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate);
                    if (dtt != null)
                    dt.Merge(dtt);
                    var dt1 = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate.AddDays(1));

                    if (dt1 != null)
                        dt.Merge(dt1);
                }
                else if (isSelected2 && isSelected3)
                {
                    var dt1 = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate.AddDays(-1));
                    var dt2 = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate.AddDays(1));

                    if (dt1 != null)
                        dt.Merge(dt1);

                    if (dt2 != null)
                        dt.Merge(dt2);
                }
                else if (isSelected1)
                {
                    dt = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate);
                }
                else if (isSelected2)
                {
                    dt = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate.AddDays(-1));
                }
                else if (isSelected3)
                {
                    dt = controllerObj.GetActiveReservationsWithDate(clinicid, SelectedDate.AddDays(1));
                }

                if (dt != null)
                {
                    kryptonDataGridView1.DataSource = dt;
                    kryptonDataGridView1.Refresh();
                }

            }
        }
        private void kryptonCheckButton2_Click(object sender, EventArgs e)
        {
            
        
            RefreshTable();
        }

        private void kryptonCheckButton3_Click(object sender, EventArgs e)
        {
           
            RefreshTable();
        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {
      
            RefreshTable();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
