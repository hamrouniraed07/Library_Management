using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public static class SqlConnectionManager
    {
        private static readonly string _connectionString =
            "Data Source=DESKTOP-1L996PU;Initial Catalog=Library;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }

}
