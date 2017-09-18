using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TK_Cons_F_v0.DAO
{
    public class UserDAO
    {
        private dbConnection connection;

        /// <constructor>
        /// Constructor UserDAO
        /// </constructor>
        public UserDAO()
        {
            connection = new dbConnection();
        }

        /// <method>
        /// Get User Email By Firstname or Lastname and return DataTable
        /// </method>
        /// 

    }
}
