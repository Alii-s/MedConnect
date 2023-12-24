﻿using MedConnect.Doctor.PatientsInfo;
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
    public partial class DoctorMainForm : Form
    {
        int UserId;
        public DoctorMainForm(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            DoctorPatientsInfo updateInfoForm = new DoctorPatientsInfo(UserId);
            updateInfoForm.Show();
            this.Hide();
            
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            DoctorScheuale doctorScheuale = new DoctorScheuale(UserId);
            doctorScheuale.Show();
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ClinicsAppointments clinicsAppointments = new ClinicsAppointments(UserId);
            clinicsAppointments.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DoctorRating_Comments doctorRating_Comments = new DoctorRating_Comments(UserId);
            doctorRating_Comments.Show();
            this.Hide();
        }
    }
}
