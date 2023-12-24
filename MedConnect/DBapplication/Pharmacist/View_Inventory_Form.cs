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
    public partial class View_Inventory_Form : Form
    {
        readonly int UserID;
        int viewMode;
        PharmacistController controller;

        public View_Inventory_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            controller = new PharmacistController();
            kryptonComboBox1.DataSource = new String[] { "All medicine", "Expired medicine only" };
            viewMode = 0;
            DataGridUpdate();
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

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewMode = kryptonComboBox1.SelectedIndex;
            DataGridUpdate();
        }

        private void DataGridUpdate()
        {
            DataTable dt = null;

            switch (viewMode)
            {
                case 0:
                    dt = controller.getMedicine();
                    break;

                case 1:
                    dt = controller.getExpiredMedicine(DateTime.Today);
                    break;
            }

            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
        }
    }
}
