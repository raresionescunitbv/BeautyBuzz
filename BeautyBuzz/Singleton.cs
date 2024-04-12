using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyBuzz
{
    public sealed class SingleTon
    {
        private static readonly SingleTon instance = new SingleTon();
        public static SingleTon Instance => instance;

        private SqlConnection connection;
        private string connectionString = "Server=DESKTOP-BK0V8HA\\SQLEXPRESS;Database=BeautyBuzz;Trusted_Connection=True;Encrypt=true;TrustServerCertificate=true;";

        private SingleTon()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }

}
