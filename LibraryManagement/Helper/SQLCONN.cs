using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryManagement
{
    class SQLCONN
    {
        public SqlConnection connection;
        
        public void Connect()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-NBOJDLR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True;Pooling=False");
        }
    }
}
