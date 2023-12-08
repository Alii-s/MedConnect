using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace MedConnect
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

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
