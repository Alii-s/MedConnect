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
    public partial class Delete_Medicine_Form : Form
    {
        readonly int UserID;
        PharmacistController controller;

        public Delete_Medicine_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            controller = new PharmacistController();
            DataTable dt = controller.getMedicine();
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
            kryptonComboBox1.DisplayMember = "Name";
            kryptonComboBox1.ValueMember = "ID";
            kryptonComboBox1.DataSource = dt;
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult choice = KryptonMessageBox.Show("This medicine will be deleted.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (choice == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                int queryResult = controller.deleteMedicine(Convert.ToInt32(kryptonComboBox1.SelectedValue));
                if (queryResult == 0)
                {
                    KryptonMessageBox.Show("Deletion failed", "Error");
                }
                else
                {
                    KryptonMessageBox.Show("Deleted successfully", "Success");
                    DataTable dt = controller.getMedicine();
                    kryptonComboBox1.DataSource = dt;
                    kryptonDataGridView1.DataSource = dt;
                    kryptonDataGridView1.Refresh();
                }
            }
        }
    }
}
