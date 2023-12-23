using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedConnect.Secertary;

namespace MedConnect.Secretary
{
    public partial class Secretary : Form
    {
        int UserID;
        SecretaryController secretaryController = new SecretaryController();
        public Secretary(int userID)
        {
            InitializeComponent();
            UserID = userID;

            string t = secretaryController.GetSecName(UserID).ToString(); 
           label2.Text = t;
            // Name.Refresh();
        }

        private void updatInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateSecretaryInfo f = new UpdateSecretaryInfo(UserID);
            f.Show();
          

        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 