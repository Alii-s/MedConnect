using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MedConnect.Doctor
{
    internal class DoctorController
    {
        DBManager dbMan;

        #region Constructor
        public DoctorController()
        {
            dbMan = new DBManager();
        }
        #endregion

        #region Get Session Ratings With Comments
        public DataTable GetSessionRatingsWithComments()
        {
            string StoredProcedureName = DoctorStoredProcedures.GetSessionRatingsWithComments;

            return dbMan.ExecuteReader(StoredProcedureName);
        }
        #endregion

        #region Get Average Rating
        public float GetAverageRating()
        {
            string StoredProcedureName = DoctorStoredProcedures.GetAverageRating;


            return float.Parse(dbMan.ExecuteScalar(StoredProcedureName).ToString());
        }
        #endregion

        #region Get Active Reservations With Date
        public DataTable GetActiveReservationsWithDate(int ClinicId, DateTime Date)
        {
            string StoredProcedureName = DoctorStoredProcedures.GetActiveReservationsWithDate;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@InputDate", Date);
            Parameters.Add("@ClinicId", ClinicId);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        #endregion

        #region Get Doctor Name
        //public string GetDoctorName(int DoctorID)
        //{
        //    string StoredProcedureName = DoctorStoredProcedures.GetDoctorName;

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@DoctorID", DoctorID);

        //    return dbMan.ExecuteScalar(StoredProcedureName, Parameters).ToString();
        //}
        #endregion

        #region GetSchedule
        public DataTable GetDayAtSchedule(int DoctorID,  string Day)
        {
            string StoredProcedureName = DoctorStoredProcedures.GetDayAtSchedule;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Day", Day);
            Parameters.Add("@DoctorID", DoctorID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        #endregion

        #region Select All Patients
        public DataTable SelectAllPatients()
        {
            string StoredProcedureName = DoctorStoredProcedures.GetDoctorPatients;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        #endregion

        #region Select All Patients With Filter
        public DataTable SelectAllPatientsWithFilter(string Fname, string Lname, string PhoneNumber)
        {
            string StoredProcedureName = DoctorStoredProcedures.GetDoctorPatientsWithFilter;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@PhoneNumber", PhoneNumber);


            // Pass the parameters to the ExecuteReader method
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        #endregion

        #region Get All ClinicData
        public DataTable SelectAllClinicData()
            {
                string StoredProcedureName = DoctorStoredProcedures.GetAllClinicData;
                return dbMan.ExecuteReader(StoredProcedureName, null);
            }
        #endregion


        #region Add Doctor Schedule
        public int AddDoctorSchedule(int DoctorID, int ClinicID, string Day, int StartTime, int EndTime)
        {
            //assume the start and end time will be integer from 0 to 23 dont forget to tell TA
     
            TimeSpan StartTimeSpan = TimeSpan.FromHours(StartTime);
            TimeSpan EndTimeSpan = TimeSpan.FromHours(EndTime);


            string StoredProcedureName = DoctorStoredProcedures.AddDoctorSchedule;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DoctorID", DoctorID);
            Parameters.Add("@ClinicID", ClinicID);
            Parameters.Add("@Day", Day);
            Parameters.Add("@StartT", StartTimeSpan);
            Parameters.Add("@EndT", EndTimeSpan);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        #endregion

        #region Delete Doctor Schedule
        public int DeleteDoctorSchedule(int DoctorID, int ClinicID, string Day)
        {

            string StoredProcedureName = DoctorStoredProcedures.DeleteDoctorSchedule;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DoctorID", DoctorID);
            Parameters.Add("@ClinicID", ClinicID);
            Parameters.Add("@Day", Day);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);


        }
        #endregion

        #region Get Doctor Schedule
        public DataTable GetDoctorSchedule(int DoctorID)
        {
            string StoredProcedureName = DoctorStoredProcedures.GetDoctorSchedule;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DoctorID", DoctorID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        #endregion

        #region SomeHelperFunctions
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

        #endregion

        #region TerminationOfConnection
        public void TerminateConnection()
            {
                dbMan.CloseConnection();
            }
        #endregion


    }
}
