using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public class Database : IDatabase
    {
        public SqlConnection GetConnection()
        {
            // Logica de creare a conexiunii
            return new SqlConnection("Server = localhost\\sqltest, 1401; Database = BeautyBuzz; User ID = sa; Password = test@123; Encrypt = true; TrustServerCertificate = true; ");
        }

        public ISqlCommand CreateCommand(SqlConnection connection)
        {
            return new SqlCommandWrapper(new SqlCommand { Connection = connection });
        }
    }
}
