using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class DBConn
    {
        private static DBConn dbInstance = null;
        private readonly SqlConnection conn;

        private DBConn()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-NBOJDLR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Pooling=False");
        }

        public static DBConn GetInstance()
        {
            if(dbInstance == null)
            {
                dbInstance = new DBConn();
            }

            return dbInstance;
        }

        public SqlConnection GetDBConnection()
        {
            return conn;
        }
    }
}
