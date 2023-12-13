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
        public DoctorMainForm()
        {
            InitializeComponent();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            DoctorPatientsInfo updateInfoForm = new DoctorPatientsInfo();
            updateInfoForm.Show();
            this.Hide();
            
        }
    }
}
