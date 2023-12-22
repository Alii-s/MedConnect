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

namespace MedConnect.Pharmacist
{
    public partial class Medical_Inventory_Form : Form
    {
        readonly int UserID;
        public Medical_Inventory_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Pharmacist_Main_Form form = new Pharmacist_Main_Form(UserID);
            form.Show();
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Medicine_Form form = new Add_Medicine_Form(UserID);
            form.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            View_Inventory_Form form = new View_Inventory_Form(UserID);
            form.Show();
        }

        private void deleteMedicine_Click(object sender, EventArgs e)
        {
            this.Close();
            Delete_Medicine_Form form = new Delete_Medicine_Form(UserID);
            form.Show();
        }

        private void updateStock_Click(object sender, EventArgs e)
        {
            this.Close();
            Update_Stock_Form form = new Update_Stock_Form(UserID);
            form.Show();
        }
    }
}