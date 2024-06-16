using Microsoft.Data.SqlClient;
using System;

namespace BeautyBuzz
{
    public sealed class SingleTon
    {
        private static readonly SingleTon instance = new SingleTon();
        private SqlConnection connection;
        private readonly string connectionString = "Server=localhost\\sqltest,1401;Database=BeautyBuzz;User ID=sa;Password=test@123;Encrypt=true;TrustServerCertificate=true;";
        private static readonly object padlock = new object();

        private SingleTon()
        {
            InitializeConnection();
        }

        public static SingleTon Instance => instance;

        private void InitializeConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                Console.WriteLine("Connection initialized with connection string.");
            }
            else if (string.IsNullOrEmpty(connection.ConnectionString))
            {
                connection.ConnectionString = connectionString;
                Console.WriteLine("Connection string re-initialized.");
            }
        }

        public SqlConnection GetConnection()
        {
            lock (padlock)
            {
                InitializeConnection();
                return connection;
            }
        }

        public void OpenConnection()
        {
            lock (padlock)
            {
                var conn = GetConnection();
                if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
                {
                    Console.WriteLine("Opening connection...");
                    conn.Open();
                    Console.WriteLine("Connection opened.");
                }
            }
        }

        public void CloseConnection()
        {
            lock (padlock)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Closing connection...");
                    connection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }
        }
    }
}
