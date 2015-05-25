using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DBConnection {
    public static class IDBConnectionExtention {

        public static IEnumerable<T> Query<T>(this IDbConnection connection, QueryObject queryObject) {
            return connection.Query<T>(queryObject.Sql, queryObject.QueryParams);
        }

    }
}
