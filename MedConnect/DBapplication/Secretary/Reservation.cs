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
using MedConnect.Secertary;

namespace MedConnect.Secretary
{
    public partial class Reservation : Form
    {
        SecretaryController secretaryController = new SecretaryController();
        int UserId;
        public Reservation(int userID)
        {
            InitializeComponent();

            UserId = userID;

            DataTable dt = secretaryController.SelectReservations();
            ReservT.DataSource = dt;
             
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            int res = 0;
            int countDone = 0; ;
            for (int i = 0; i < ReservT.RowCount; i++)
            {

                int IsConf = Convert.ToInt16(ReservT.Rows[i].Cells[5].Value);
                int RID = Convert.ToInt16(ReservT.Rows[i].Cells[6].Value);
                res = secretaryController.updateIsConf(RID, IsConf);
                if (res != 0)
                {
                    countDone ++;
                }
            }
            if(countDone == 0)
            {
                KryptonMessageBox.Show("Updates was not saved");
            }
            else
                KryptonMessageBox.Show("Saved");
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Secretary form = new Secretary(UserId);
            form.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Trigger trigger = new Trigger();
            trigger.Show();
            this.Close();
        }
    }
}
