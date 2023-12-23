using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedConnect.Doctor
{
    internal class DoctorStoredProcedures
    {

            public static string GetDoctorPatients = "GetDoctorPatients";
        public static string GetDoctorPatientsWithFilter = "GetDoctorPatientsWithFilter";
        public static string GetAllClinicData = "GetAllClinicData";
        public static string AddDoctorSchedule = "AddDoctorSchedule";
        public static string GetDoctorSchedule = "GetDoctorScheuale";
        public static string DeleteDoctorSchedule = "DeleteDoctorSchedule"; 
        public static string GetDayAtSchedule = "GetSchedule";

    }
}
