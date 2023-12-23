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
        public static string GetExpiredMedicine = "getExpiredMedicine";
        public static string DeleteMedicine = "deleteMedicine";
        public static string AddMedicine = "insertMedicine";
    }
}
