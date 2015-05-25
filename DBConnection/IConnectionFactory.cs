namespace DBConnection {
    using System.Data;

    public interface IConnectionFactory {
        IDbConnection CreateConnection();
    }
}
