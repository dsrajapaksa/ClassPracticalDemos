using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WorkingWithSQL.Connection
{
    class DBConnection
    {
        public static string conString =
            @"Data Source=DESKTOP-TG2D98G\SQLEXPRESS;initial catalog=SchoolDB;
                Integrated Security=True;MultipleActiveResultSets=True";

        static SqlConnection con;

        public static SqlConnection  getConnection()
        {
            try
            {
                con = new SqlConnection(conString);
                return con;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
