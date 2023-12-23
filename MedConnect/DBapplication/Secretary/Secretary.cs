﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedConnect.Patient;

namespace MedConnect.Secretary
{
    public partial class Secretary : Form
    {
        int UserID;
        public Secretary(int userID)
        {
            InitializeComponent();
        }

        private void MUbill_Click(object sender, EventArgs e)
        {
            this.Close();
            MUbills frm = new MUbills(UserID);
            frm.Show();
        }
    }
}
