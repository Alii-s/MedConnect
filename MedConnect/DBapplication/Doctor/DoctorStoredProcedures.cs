﻿using System;
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
        public static string GetActiveReservationsWithDate = "GetActiveReservationsWithInfo"; 
        public static string GetSessionRatingsWithComments = "GetSessionRatingsWithComments"; 
        public static string GetAverageRating = "GetAverageRating"; 
        public static string InsertIntoDiagnosisSessionsAndMedicalRecords = "InsertIntoDiagnosisSessionsAndMedicalRecords";
        public static string SelectSessionId = "SelectSessionId";
        public static string GetActiveNonExpiredMedicines = "GetActiveNonExpiredMedicines";
        public static string InsertIntoPrescription = "InsertIntoPrescribed";
        public static string GetMostRepeatedTypeInDiagnosisSessions = "GetMostRepeatedTypeInDiagnosisSessions";
        public static string CountRepeatedDatesInDiagnosisSession = "CountRepeatedDatesInDiagnosisSession";
        //very important note i have discovered that iam idiot and that i could literally do like 3 procedures in only one procedure
        //but its 3am never too late to learn i guess
        public static string GetPatientsByName = "GetPatientsByName";
        public static string GetPatientsByPhone = "GetPatientsByPhone";
    }
}
