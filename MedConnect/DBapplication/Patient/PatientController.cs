using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public DataTable SelectPatientInfo(int ID)
        {
            string query = "SELECT Fname,Lname,Email,PhoneNumber,Gender,DateOfBirth,Occupation,Building_num,Street_Name,City,Marital_State FROM Patients,Users WHERE PatientID=" + ID + " AND PatientID=UserID AND Users.IsActive=1;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectPatientRecords(int ID)
        {
            string query = "SELECT Previous_illness AS 'Previous Illnesses', Ongoing_medication as 'Ongoing Medication',Previous_Surgeries as 'Previous Surgeries' FROM Users,Patients,MedicalRecords WHERE MedicalRecords.PatientID=" + ID + " AND MedicalRecords.PatientID=UserID AND Patients.PatientID=MedicalRecords.PatientID AND Users.IsActive=1;";
            return dbMan.ExecuteReader(query);
        }
        public object SelectPatientName(int ID)
        {
            string query = "SELECT Fname FROM Patients,Users WHERE PatientID=" + ID + " AND PatientID=UserID;";
            return dbMan.ExecuteScalar(query);
        }
        public int UpdatePatientInfo(int UserID, string Fname, string Lname, string PhoneNumber, string occupation, string City, int Building_Num, string Street_Name, string Marital_State)
        {
            string StoredProcedureName = PatientStoredProcedures.UpdatePatient;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserID", UserID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@occupation", occupation);
            Parameters.Add("@City", City);
            Parameters.Add("@Building_Num", Building_Num);
            Parameters.Add("@Street_Name", Street_Name);
            Parameters.Add("@Marital_State", Marital_State);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetSessionInfo(int UserID,DateTime StartDate, DateTime EndDate)
        {
            string StoredProcedureName = PatientStoredProcedures.GetSessionInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserID", UserID);
            Parameters.Add("@StartDate", StartDate);
            Parameters.Add("@EndDate", EndDate);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
    }
}
