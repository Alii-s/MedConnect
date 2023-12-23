using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MedConnect.Pharmacist
{
    internal class PharmacistController
    {
        DBManager dbMan;

        public PharmacistController()
        {
            dbMan = new DBManager();
        }

        public object getPharmacistName(int UserID)
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetPharmacistFname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserID", UserID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable getMedicine()
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetMedicine;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable getExpiredMedicine(DateTime today_date)
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetExpiredMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@today_date", today_date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int deleteMedicine(int ID)
        {
            string StoredProcedureName = PharmacistStoredProcedures.DeleteMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int addMedicine(string name, float price, int quantity, DateTime expiration_date)
        {
            string StoredProcedureName = PharmacistStoredProcedures.AddMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@price", price);
            Parameters.Add("@quantity", quantity);
            Parameters.Add("@expiration_date", expiration_date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}