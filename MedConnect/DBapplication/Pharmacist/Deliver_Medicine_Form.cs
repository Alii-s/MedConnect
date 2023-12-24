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

namespace MedConnect.Pharmacist
{
    public partial class Deliver_Medicine_Form : Form
    {
        readonly int UserID;
        PharmacistController controller;

        public Deliver_Medicine_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            controller = new PharmacistController();
            updatePrescriptions();
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

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '0')
            {
                if ((sender as KryptonTextBox).Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void deliverButton_Click(object sender, EventArgs e)
        {
            quantityLabel.Visible = false;

            if (quantityTextBox.Text.Length == 0)
            {
                quantityLabel.Visible = true;
                return;
            }

            int quantityToDeliver = Convert.ToInt32(quantityTextBox.Text);
            int prescription_ID = Convert.ToInt32(kryptonComboBox1.SelectedValue);
            int quantityAvailabe = Convert.ToInt32(controller.getMedicineQuantityByPrescriptionID(prescription_ID));

            if (quantityAvailabe < quantityToDeliver)
            {
                KryptonMessageBox.Show("Out of stock", "Error");
                return;
            }

            int queryResult = controller.deliverMedicine(quantityToDeliver, prescription_ID, UserID);

            if (queryResult == 0)
            {
                KryptonMessageBox.Show("Deliver failed", "Error");
            }
            else
            {
                KryptonMessageBox.Show("Delivered successfully", "Success");
                updatePrescriptions();
            }

        }

        private void updatePrescriptions()
        {
            DataTable dt = controller.getNotDeliveredPrescriptions();
            kryptonComboBox1.DisplayMember = "Prescription_ID";
            kryptonComboBox1.ValueMember = "Prescription_ID";
            kryptonComboBox1.DataSource = dt;
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
        }
    }
}
