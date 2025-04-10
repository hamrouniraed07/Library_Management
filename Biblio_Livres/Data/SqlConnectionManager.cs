using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Biblio_Livres.Data
{
    public static class SqlConnectionManager
    {
        private static readonly string _connectionString =
            "Data Source=LAPTOP-MIQGSNDC;Initial Catalog=Library;Integrated Security=True;Encrypt=False;Trust Server Certificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
