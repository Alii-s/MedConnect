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
    public partial class Billing_History_Form : Form
    {
        readonly int UserID;
        PharmacistController controller;

        public Billing_History_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            controller = new PharmacistController();
            kryptonComboBox1.DataSource = new String[] { "All bills", "Filter by date" };
            update();

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

        private void update()
        {
            if (kryptonComboBox1.SelectedIndex == 0)
            {
                fromDate.Visible = false;
                toDate.Visible = false;
                fromLabel.Visible = false;
                toLabel.Visible = false;

                DataTable dt = controller.getMedicineDeliveryBills();
                kryptonDataGridView1.DataSource = dt;
                kryptonDataGridView1.Refresh();
                revenueTextBox.Text = Convert.ToString(controller.getPharmacyTotalRevenue());
            }
            else
            {
                fromDate.Visible = true;
                toDate.Visible = true;
                fromLabel.Visible = true;
                toLabel.Visible = true;

                DataTable dt = controller.getMedicineDeliveryBillsByDate(fromDate.Value, toDate.Value);
                kryptonDataGridView1.DataSource = dt;
                kryptonDataGridView1.Refresh();
                revenueTextBox.Text = Convert.ToString(controller.getPharmacyTotalRevenueByDate(fromDate.Value, toDate.Value));
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
