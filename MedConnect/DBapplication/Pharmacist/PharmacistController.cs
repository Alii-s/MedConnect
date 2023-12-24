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

        public DataTable getNotDeliveredPrescriptions()
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetNotDeliveredPrescriptions;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable getMedicineByID (int ID)
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetMedicineByID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getMedicineDeliveryBills()
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetMedicineDeliveryBills;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable getMedicineDeliveryBillsByDate(DateTime from_date, DateTime to_date)
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetMedicineDeliveryBillsByDate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@from_date", from_date);
            Parameters.Add("@to_date", to_date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public object getPharmacyTotalRevenue()
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetPharmacyTotalRevenue;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object getPharmacyTotalRevenueByDate(DateTime from_date, DateTime to_date)
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetPharmacyTotalRevenueByDate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@from_date", from_date);
            Parameters.Add("@to_date", to_date);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
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

        public object getMedicineQuantityByPrescriptionID(int ID)
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetMedicineQuantityByPrescriptionID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object getNumberOfMedicine()
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetNumberOfMedicine;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public object getNumberOfExpiredMedicine(DateTime today_date)
        {
            string StoredProcedureName = PharmacistStoredProcedures.GetNumebrOfExpiredMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@today_date", today_date);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int deliverMedicine(int quantity, int prescription_ID, int pharmacist_ID)
        {
            DateTime td = DateTime.Now;

            string StoredProcedureName = PharmacistStoredProcedures.DeliverMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@quantity", quantity);
            Parameters.Add("@prescription_ID", prescription_ID);
            Parameters.Add("@pharmacistID", pharmacist_ID);
            Parameters.Add("@today_date", td);
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

        public int setMedicineQuantity(int ID, int quantity)
        {
            string StoredProcedureName = PharmacistStoredProcedures.SetMedicineQuantity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@quantity", quantity);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int incrementMedicineQuantity(int ID, int amount)
        {
            string StoredProcedureName = PharmacistStoredProcedures.IncrementMedicineQuantity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@amount", amount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}