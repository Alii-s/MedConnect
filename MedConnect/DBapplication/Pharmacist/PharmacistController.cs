using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Pharmacist
{
    internal class PharmacistController
    {
        DBManager dbMan;

        public PharmacistController()
        {
            dbMan = new DBManager();
        }

        public object getPharmacistName(int ID)
        {
            string query = "SELECT Fname FROM Pharmacists,Users WHERE PharmacistID=" + ID + " AND PharmacistID=UserID;";
            return dbMan.ExecuteScalar(query);
        }
    }
}
