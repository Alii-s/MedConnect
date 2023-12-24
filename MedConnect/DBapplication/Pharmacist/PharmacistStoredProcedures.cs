using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Pharmacist
{
    internal class PharmacistStoredProcedures
    {
        public static string GetPharmacistFname = "getPharmacistFname";
        public static string GetMedicine = "getMedicine";
        public static string GetMedicineByID = "getMedicineByID";
        public static string GetExpiredMedicine = "getExpiredMedicine";
        public static string SetMedicineQuantity = "setMedicineQuantity";
        public static string IncrementMedicineQuantity = "incrementMedicineQuantity";
        public static string DeleteMedicine = "deleteMedicine";
        public static string AddMedicine = "insertMedicine";
        public static string GetNotDeliveredPrescriptions = "getNotDeliveredPrescriptions";
        public static string GetMedicineQuantityByPrescriptionID = "getMedicineQuantityByPrescriptionID";
        public static string DeliverMedicine = "deliverMedicine";
        public static string GetMedicineDeliveryBills = "getMedicineDeliveryBills";
        public static string GetPharmacyTotalRevenue = "getPharmacyTotalRevenue";
        public static string GetMedicineBillsByDate = "getMedicineBillsByDate";
        public static string GetPharmacyTotalRevenueByDate = "getPharmacyTotalRevenueByDate";
        public static string GetNumberOfMedicine = "getNumberOfMedicine";
        public static string GetNumebrOfExpiredMedicine = "getNumebrOfExpiredMedicine";
        public static string GetMedicineDeliveryBillsByDate = "getMedicineDeliveryBillsByDate";
    }
}
