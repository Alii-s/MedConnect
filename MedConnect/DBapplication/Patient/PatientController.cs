using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Patient
{
    internal class PatientController
    {
        DBManager dbMan;

        public PatientController()
        {
            dbMan = new DBManager();
        }
        public object SelectPatientName(int ID)
        {
            string query = "SELECT Fname FROM Patients,Users WHERE PatientID="+ID+" AND PatientID=UserID;";
            return dbMan.ExecuteScalar(query);
        }
    }
}
