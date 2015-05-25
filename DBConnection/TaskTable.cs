using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection {
    public class TaskTable {

        public IEnumerable<TaskRow> SelectAll() {
            using (var connection = new DefaultConnectionFactory().CreateConnection()) {
                return connection.Query<TaskRow>(new TaskTableQueries().SelectAll()).ToList();
            }
        }
    }
}
