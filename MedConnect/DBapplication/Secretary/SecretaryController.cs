using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Patient;
using MedConnect.Secretary;

namespace MedConnect.Secertary
{
    internal class SecretaryController
    {
        DBManager dbMan = new DBManager();

        public DataTable SelectSecrtaryInfo(int userId)
        {
            string query = "SELECT UserID , Fname , Lname , Email , PhoneNumber, Gender, Users.Password, DateOfBirth, Salary FROM Users, Secretaries WHERE UserID = userId  AND UserId = SecretaryID;";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateSecretaryInfo(int UserID, string Fname, string Lname, string PhoneNumber, int Salary)
        {
            string StoredProcedureName = SecretaryProcdures.UpdateSecretary;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserID", UserID);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@Salary", Salary);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetSecName(int UserId) 
        {

            string query = "SELECT Fname FROM Users WHERE UserID =" + UserId +";";
            return dbMan.ExecuteScalar(query);

        }
        public DataTable SelectPatientsName()
        {
            string query = "SELECT Lname , UserID FROM Users WHERE Type = 'P';";
            return dbMan.ExecuteReader(query);
        }
        public int UpdatePatientInfo(int PatientID,int UserID, string Fname, string Lname, string PhoneNumber, string occupation, string City, int Building_Num, string Street_Name, string Marital_State)
        {
            string StoredProcedureName = SecretaryProcdures.UpdatePatient;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CreatedBy", UserID);
            Parameters.Add("@UserID", PatientID);
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
        public DataTable SelectDoctorName()
        {
            string query = "SELECT Lname , UserID FROM Users WHERE Type = 'D';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectClinicLoc()
        {
            string query = "SELECT ClinicID, City FROM Clinics ;";
            return dbMan.ExecuteReader(query);
        }
        public object GetOffer(int UserId)
        {

            string query = "SELECT Percentage FROM offers WHERE PatientID =" + UserId + ";";
            return dbMan.ExecuteScalar(query);

        }
        public int UpdateBill(int PatientID, int SecretaryID, int DoctorID, DateTime daate, int ClinicID, int price, string MofPay,bool IsPaid)
        {
             
            int offer=Convert.ToInt32( GetOffer(PatientID));
            price = price - (price*offer/100);
            //if(Type == "Follow-Up")
            //{
            //    totalPay = 300 - ((offer / 100) * 300);
            //}
            //else
            //{
            //    totalPay = 500 - ((offer / 100) * 500);
            //}
            string StoredProcedureName = SecretaryProcdures.UpdateBill;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatientID", PatientID);
            Parameters.Add("@SecretaryID", SecretaryID);
            Parameters.Add("@DoctorID", DoctorID);
            Parameters.Add("@daate", daate);
            Parameters.Add("@ClinicID", ClinicID);
            Parameters.Add("@MofPay", MofPay);
            Parameters.Add("@IsPaid", IsPaid);
            Parameters.Add("@price", price);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int CreateBill(int PatientID, int SecretaryID, int DoctorID, DateTime daate, int ClinicID, int price, string MofPay, bool IsPaid)
        {

            int offer = Convert.ToInt32(GetOffer(PatientID));
            price = price - (price * offer / 100);
            //if(Type == "Follow-Up")
            //{
            //    totalPay = 300 - ((offer / 100) * 300);
            //}
            //else
            //{
            //    totalPay = 500 - ((offer / 100) * 500);
            //}
            string StoredProcedureName = SecretaryProcdures.CreateBill;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatientID", PatientID);
            Parameters.Add("@SecretaryID", SecretaryID);
            Parameters.Add("@DoctorID", DoctorID);
            Parameters.Add("@daate", daate);
            Parameters.Add("@ClinicID", ClinicID);
            Parameters.Add("@MofPay", MofPay);
            Parameters.Add("@IsPaid", IsPaid);
            Parameters.Add("@price", price);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

    }

}
