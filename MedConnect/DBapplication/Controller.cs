using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MedConnect.Doctor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MedConnect
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        #region Login
        public DataTable Login(string Email, string Password)
        {
            string StoredProcedureName = GeneralStoredProcedures.GetEmailPassword;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            Parameters.Add("@Password", Password);


            // Pass the parameters to the ExecuteReader method
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        #endregion
        #region Register
        public int Register(string Fname, string Lname, string Email, string PhoneNumber, string Gender, string Password, DateTime DateOfBirth, string occupation, string City, int Building_Num, string Street_Name, string Marital_State,int CreatedBy)
        {
            string StoredProcedureName = GeneralStoredProcedures.RegisterPatient;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Email", Email);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Password", Password);
            Parameters.Add("@DateOfBirth", DateOfBirth);
            Parameters.Add("@occupation", occupation);
            Parameters.Add("@City", City);
            Parameters.Add("@Building_Num", Building_Num);
            Parameters.Add("@Street_Name", Street_Name);
            Parameters.Add("@Marital_State", Marital_State);
            Parameters.Add("@CreatedBy", CreatedBy);



            // Pass the parameters to the ExecuteReader method
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        #endregion
        #region Retrieve ID
        public object RetrieveID(string Email)
        {
            string StoredProcedureName = GeneralStoredProcedures.RetrieveID;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);


            // Pass the parameters to the ExecuteReader method
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        #endregion
        #region Change Password
        public object checkPassword(int UserID, string password)
        {
            string StoredProcedureName = GeneralStoredProcedures.CheckPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserID", UserID);
            Parameters.Add("@password", password);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int changePassword(int UserID, string password)
        {
            string StoredProcedureName = GeneralStoredProcedures.ChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserID", UserID);
            Parameters.Add("@password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName,Parameters);
        }

        public object getUserType(int UserID)
        {
            string StoredProcedureName = GeneralStoredProcedures.GetUserType;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserID", UserID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        #endregion
        //public int InsertStudent(string fName, string lName, int SSN, string Address, int dNum)
        //{
        //    string query = "INSERT INTO Student (Fname, Lname, SSN, Address,Dnum) " +
        //                    "Values ('" + fName + "','" + lName + "','" + SSN + "','" + Address + "',"+ dNum + ");";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int DeleteAssignment(string anum)
        //{
        //    string query = "DELETE FROM Assignment WHERE Anumber='" + anum + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int UpdateStudent(string fName, string lName, string Address, int SSN)
        //{
        //    string query = "UPDATE Student SET Fname='" + fName + "', Lname='"+ lName +"',Address='"+ Address+ "' WHERE SSN='" + SSN + "';";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public DataTable SelectAllStudents(string Dnum)
        //{
        //    string query = "SELECT * FROM Student,Department WHERE Dnum = Dnumber AND Dname= '"+ Dnum +"';";
        //    return dbMan.ExecuteReader(query);
        //}

        //public int CountStudents(int Anum)
        //{
        //    string query = "SELECT COUNT(Sssn) FROM Solves WHERE Ano = '"+ Anum +"';";
        //    return (int)dbMan.ExecuteScalar(query);
        //}

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
