﻿using MedConnect.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Pharmacist
{
    public partial class Pharmacist_Main_Form : Form
    {
        readonly int UserID;
        PharmacistController controller;
        public Pharmacist_Main_Form(int UserID)
        {
            InitializeComponent();
            controller = new PharmacistController();
            this.UserID = UserID;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void PharmacistMainForm_Load(object sender, EventArgs e)
        {
            label1.Text += " " + controller.getPharmacistName(UserID).ToString();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medical_Inventory_Form form = new Medical_Inventory_Form(UserID);
            form.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deliver_Medicine_Form form = new Deliver_Medicine_Form(UserID);
            form.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing_History_Form form = new Billing_History_Form(UserID);
            form.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicine_Prescription_Statistics_Form form = new Medicine_Prescription_Statistics_Form(UserID);
            form.Show();
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
    }
}
