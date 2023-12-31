﻿using MedConnect.Doctor;
using MedConnect.Patient;
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
    public partial class AdminMainForm : Form
    {
        int UserID;
        AdminController adminController = new AdminController();
        public AdminMainForm(int UserID)
        {
            this.UserID = UserID;
            InitializeComponent();
            label1.Text +=" " + adminController.SelectName(UserID);

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

        private void updatInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser addUser = new AddUser(UserID);
            addUser.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password_Form form = new Change_Password_Form(UserID);
            form.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label2.Font.Style | FontStyle.Underline);
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label2.Font.Style & ~FontStyle.Underline);
            this.Cursor = Cursors.Default;
        }

        private void kryptonButton1_Click(object sender, EventArgs e) //remove user button
        {
            this.Close();
            RemoveUser form = new RemoveUser(UserID);
            form.Show();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            this.Close();
            DoctorMainForm form = new DoctorMainForm(UserID,1);
            form.Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCl_Click(object sender, EventArgs e)
        {
            this.Close();
            AddClinic form = new AddClinic(UserID);
            form.Show();    
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            this.Close();
            ClinicStatistics c = new ClinicStatistics(UserID);
            c.Show();
        }
    }
}
