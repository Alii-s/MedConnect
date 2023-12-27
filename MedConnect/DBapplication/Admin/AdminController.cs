using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedConnect.Admin;
using MedConnect.Secretary;

namespace MedConnect
{
    internal class AdminController
    {
        DBManager dbMan = new DBManager();

        public object SelectName(int ID)
        {
            string query = "SELECT Fname FROM Users WHERE UserID=" + ID;
            return dbMan.ExecuteScalar(query);
        }

        public int AddSecretary(int adminID, string Fname, string Lname, string email, string PhoneNumber, string gender, string password, DateTime DOB, int Salary, int CID, DateTime Hdate)
        {
            string StoredProcedureName = AdminProcdures.AddSecretary;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Createdby", adminID);

            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@email", email);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Password", password);
            Parameters.Add("@DOB", DOB);

            Parameters.Add("@Salary", Salary);
            Parameters.Add("@ClinicID", CID);
            Parameters.Add("@Hdate", Hdate);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddDoctor(int adminID, string Fname, string Lname, string email, string PhoneNumber, string gender, string password, DateTime DOB, int Salary, string certificate, string Exp, string Specialization)
        {
            string StoredProcedureName = AdminProcdures.AddDoctor;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Createdby", adminID);

            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@email", email);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Password", password);
            Parameters.Add("@DOB", DOB);

            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Exp", Exp);
            Parameters.Add("@Specialization", Specialization);
            Parameters.Add("@certificate", certificate);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddAdmin(int adminID, string Fname, string Lname, string email, string PhoneNumber, string gender, string password, DateTime DOB, int Salary, string certificate, string Exp, string Specialization)
        {
            string StoredProcedureName = AdminProcdures.AddAdmin;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Createdby", adminID);

            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@email", email);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Password", password);
            Parameters.Add("@DOB", DOB);

            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Exp", Exp);
            Parameters.Add("@Specialization", Specialization);
            Parameters.Add("@certificate", certificate);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddPharmacist(int adminID, string Fname, string Lname, string email, string PhoneNumber, string gender, string password, DateTime DOB)
        {
            //do not forget to add it to parmacist table
            string StoredProcedureName = AdminProcdures.AddPharmacist;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Createdby", adminID);

            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@email", email);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Password", password);
            Parameters.Add("@DOB", DOB);



            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddPatient(int AdminID, string Fname, string Lname, string email, string PhoneNumber, string gender, string password, DateTime DOB, string occupation, string City, int Building_Num, string Street_Name, string Marital_State)
        {
            string StoredProcedureName = AdminProcdures.AddPatient;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CreatedBy", AdminID);

            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@email", email);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@Password", password);
            Parameters.Add("@DOB", DOB);

            Parameters.Add("@occupation", occupation);
            Parameters.Add("@City", City);
            Parameters.Add("@Building_Num", Building_Num);
            Parameters.Add("@Street_Name", Street_Name);
            Parameters.Add("@Marital_State", Marital_State);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable SelectClinicLoc()
        {
            string query = "SELECT ClinicID , City FROM Clinics WHERE IsActive = 1 ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmail()
        {

            string query = "SELECT Email, UserID FROM Users WHERE IsActive =1 ;";
            return dbMan.ExecuteReader(query);
        }
        public int RemoveUser(int userID)
        {
            string query = "SELECT Type FROM Users WHERE UserID = " + userID + "";
            string type = dbMan.ExecuteScalar(query).ToString();
            string query2 = "";
            string query3 = "";
            if (type == "P")
            {
                query2 = "UPDATE Users SET IsActive = 0 WHERE UserID =  " + userID + "";
                query3 = "UPDATE Patients SET IsActive = 0 WHERE PatientID =  " + userID + "";
            }
            else if (type == "S")
            {
                query2 = "UPDATE Users SET IsActive = 0 WHERE UserID =  " + userID + "";
                query3 = "UPDATE Secretaries SET IsActive = 0 WHERE SecretaryID =  " + userID + "";
            }
            else if (type == "F")
            {
                query2 = "UPDATE Users SET IsActive = 0 WHERE UserID =  " + userID + "";
                query3 = "UPDATE Pharmacists SET IsActive = 0 WHERE PharmacistID =  " + userID + "";
            }
            else if (type == "D")
            {
                query2 = "UPDATE Users SET IsActive = 0 WHERE UserID =  " + userID + "";
                query3 = "UPDATE Doctors SET IsActive = 0 WHERE DoctorID =  " + userID + "";
            }
            else if (type == "A")
            {
                query2 = "UPDATE Users SET IsActive = 0 WHERE UserID =  " + userID + "";

            }

            if (type == "A")
            {
                return dbMan.ExecuteNonQuery(query2);
            }
                return ( dbMan.ExecuteNonQuery(query3) + dbMan.ExecuteNonQuery(query2) );


        }
        public int AddClinic(string Pnum ,int Building, string street , string city ,int sh,int sm,int eh,int em)
        {

            string query = "INSERT INTO Clinics(PhoneNumber,Building_num,Street_Name,City,Opening_Time,Close_Time,IsActive) VALUES ('"+Pnum+"',"+Building+",'"+street+"','"+city+"','"+sh+':'+sm+ "','"+eh+':'+em+"',1);";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}//install-Package Microsoft.ReportingS ervices.ReportViewerControl.WinForms-Version 140.340.80
