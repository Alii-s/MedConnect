using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
