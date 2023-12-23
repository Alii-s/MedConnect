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
    public partial class Update_Stock_Form : Form
    {
        readonly int UserID;
        PharmacistController controller;

        public Update_Stock_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            controller = new PharmacistController();

            DataTable dt = controller.getMedicine();
            kryptonComboBox1.DisplayMember = "Name";
            kryptonComboBox1.ValueMember = "ID";
            kryptonComboBox1.DataSource = dt;

            updateDataGrid();
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Medical_Inventory_Form form = new Medical_Inventory_Form(UserID);
            form.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void updateDataGrid()
        {
            kryptonDataGridView1.DataSource = null;

            kryptonDataGridView1.AutoGenerateColumns = false;
            kryptonDataGridView1.ColumnCount = 3;

            kryptonDataGridView1.Columns[0].Name = "ID";
            kryptonDataGridView1.Columns[0].HeaderText = "ID";
            kryptonDataGridView1.Columns[0].DataPropertyName = "ID";

            kryptonDataGridView1.Columns[1].Name = "Name";
            kryptonDataGridView1.Columns[1].HeaderText = "Name";
            kryptonDataGridView1.Columns[1].DataPropertyName = "Name";

            kryptonDataGridView1.Columns[2].Name = "Quantity";
            kryptonDataGridView1.Columns[2].HeaderText = "Quantity";
            kryptonDataGridView1.Columns[2].DataPropertyName = "Quantity";

            DataTable dt = controller.getMedicineByID(Convert.ToInt32(kryptonComboBox1.SelectedValue));
            kryptonDataGridView1.DataSource = dt;
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            quantityLabel.Visible = false;

            if (quantityTextBox.Text.Length == 0)
            {
                quantityLabel.Visible = true;
                return;
            }

            int ID = Convert.ToInt32(kryptonComboBox1.SelectedValue);
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            int queryResult = controller.setMedicineQuantity(ID, quantity);
            if (queryResult == 0)
            {
                KryptonMessageBox.Show("Quantity set failed", "Error");
            }
            else
            {
                KryptonMessageBox.Show("Quantity updated successfully","Success");
                updateDataGrid();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            quantityLabel.Visible = false;

            if (quantityTextBox.Text.Length == 0)
            {
                quantityLabel.Visible = true;
                return;
            }

            int ID = Convert.ToInt32(kryptonComboBox1.SelectedValue);
            int amount = Convert.ToInt32(quantityTextBox.Text);

            int queryResult = controller.incrementMedicineQuantity(ID, amount);
            if (queryResult == 0)
            {
                KryptonMessageBox.Show("Quantity increment failed", "Error");
            }
            else
            {
                KryptonMessageBox.Show("Quantity incremented successfully", "Success");
                updateDataGrid();
            }
        }
    }
}
