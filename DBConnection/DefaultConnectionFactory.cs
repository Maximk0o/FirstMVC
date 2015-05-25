namespace DBConnection {
    using Npgsql;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public class DefaultConnectionFactory : IConnectionFactory
    {
        private const string ConnectionString = "Server=127.0.0.1;Port=5432;Database=mvcapplication1;User Id=mvcapplication1;Password=123;";

        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}
