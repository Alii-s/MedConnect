using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace MedConnect.Pharmacist
{
    public partial class Add_Medicine_Form : Form
    {
        readonly int UserID;
        PharmacistController controller;

        public Add_Medicine_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            controller = new PharmacistController();
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
            Medical_Inventory_Form form = new Medical_Inventory_Form(UserID);
            form.Show();
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if ((sender as KryptonTextBox).Text.IndexOf('.') > -1 || (sender as KryptonTextBox).Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void kryptonTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            nameLabel.Visible = false;
            priceLabel.Visible = false;
            quantityLabel.Visible = false;

            bool emptyInput = false;

            if (nameTextBox.Text.Length == 0)
            {
                nameLabel.Visible = true;
                emptyInput = true;
            }

            if (priceTextBox.Text.Length == 0)
            {
                priceLabel.Visible = true;
                emptyInput = true;
            }

            if (quantityTextBox.Text.Length == 0)
            {
                quantityLabel.Visible = true;
                emptyInput = true;
            }

            if (emptyInput) return;

            string name = nameTextBox.Text;
            float price = (float) Convert.ToDouble(priceTextBox.Text);
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            DateTime expiration_date = kryptonMonthCalendar1.SelectionStart;

            int queryResult = controller.addMedicine(name, price, quantity, expiration_date);

            if (queryResult == 0)
            {
                KryptonMessageBox.Show("Addition failed","Error");
            }
            else
            {
                KryptonMessageBox.Show("Added successfully","Success");
            }
        }
    }
}
