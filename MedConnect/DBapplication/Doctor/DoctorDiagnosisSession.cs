﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace MedConnect.Doctor
{
    public partial class DoctorDiagnosisSession : Form
    {
        int DoctorID; int patientId;

        DoctorController doctorController = new DoctorController();


        public DoctorDiagnosisSession(int DoctorID,int patientId)
        {
            InitializeComponent();
            this.DoctorID = DoctorID;
            this.patientId = patientId;

            kryptonComboBox1.DataSource = doctorController.SelectAllClinicData();
            kryptonComboBox1.DisplayMember = "City";
            kryptonComboBox1.ValueMember = "ClinicID";
            sessionDate.SelectedIndex = 0;
            kryptonComboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
         
        }

        private void DoctorDiagnosisSession_Load(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sessionDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Comments_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string type = sessionDate.Text;

           int value=  doctorController.InsertIntoDiagnosisSessionsAndMedicalRecords(DoctorID, int.Parse(kryptonComboBox1.SelectedValue.ToString()), patientId
             , sessionDate.Text, date, Comments.Text, kryptonTextBox1.Text, kryptonTextBox3.Text, kryptonTextBox2.Text, kryptonTextBox4.Text);
            if (value == 0)
                KryptonMessageBox.Show("Session Not Added Successfully");
            else
            {
                KryptonMessageBox.Show("Session Added Successfully");
                this.Close();
                int sessionid = doctorController.SelectSessionId(DoctorID, int.Parse(kryptonComboBox1.SelectedValue.ToString()), patientId, type, date);
                DoctorPrescribeMedicine doctorPrescribeMedicine = new DoctorPrescribeMedicine(sessionid, DoctorID);
                doctorPrescribeMedicine.Show();
            }

        }

        private void kryptonTextBox4_TextChanged(object sender, EventArgs e)
        {

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
            DoctorViewPatients doctorViewPatients = new DoctorViewPatients(DoctorID);
            doctorViewPatients.Show();
            this.Hide();
        }
    }
}
