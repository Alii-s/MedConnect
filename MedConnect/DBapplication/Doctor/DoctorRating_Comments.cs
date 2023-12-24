using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedConnect.Doctor
{
    public partial class DoctorRating_Comments : Form
    {
        int UserId;
        DoctorController controllerObj = new DoctorController();
        public DoctorRating_Comments(int userid)
        {
            InitializeComponent();
            UserId = userid;
            float avgRatingValue = controllerObj.GetAverageRating();
            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Value = (int)avgRatingValue;
            kryptonDataGridView1.DataSource = new DoctorController().GetSessionRatingsWithComments();
            kryptonDataGridView1.Refresh();
            label4.Text = avgRatingValue.ToString();
        }

        private void DoctorRating_Comments_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
