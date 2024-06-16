using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public class SqlCommandWrapper : ISqlCommand
    {
        private readonly SqlCommand _command;

        public SqlCommandWrapper(SqlCommand command)
        {
            _command = command;
        }

        public SqlCommand CreateCommand()
        {
            return _command;
        }

        public void AddParameter(string parameterName, object value)
        {
            _command.Parameters.AddWithValue(parameterName, value);
        }

        public object ExecuteScalar()
        {
            return _command.ExecuteScalar();
        }
    }
}
