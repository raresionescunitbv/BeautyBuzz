using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public interface ISqlCommand
    {
        void AddParameter(string parameterName, object value);
        object ExecuteScalar();
    }
}
