using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public interface IDatabase
    {
        SqlConnection GetConnection();
        ISqlCommand CreateCommand(SqlConnection connection);
    }
}
