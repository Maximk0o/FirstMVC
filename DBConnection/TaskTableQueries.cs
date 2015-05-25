using System;
using System.Collections.Generic;
using System.Text;

namespace DBConnection {
    public class TaskTableQueries {
        private Dictionary<String, String> Columns = new Dictionary<string, string>();

        public TaskTableQueries() {
            Columns.Add("id", "id");
            Columns.Add("title", "title");
            Columns.Add("text", "text");
            Columns.Add("publication_date", "publication_date");
            Columns.Add("start_date", "start_date");
            Columns.Add("finish_date", "finish_date");
            Columns.Add("is_done", "is_done");
        }

        private String AllColumns() {
            return String.Join(",", Columns.Values);
        }

        public QueryObject SelectAll() {
            return new QueryObject(String.Format("SELECT {0} FROM task", AllColumns()));
        }

        public QueryObject SelectById(int id) {
            return new QueryObject(String.Format("SELECT {0} FROM task WHERE id={1}", AllColumns(), id));
        }

        public QueryObject InsertRow(Dictionary<String, String> Values) {
            return new QueryObject(
                String.Format(@"INSERT into TASK ({0}, {1}, {2}, {3}) values
                              ({4}, {5}, {6}, false)",
                              Columns["title"], 
                              Columns["text"], 
                              Columns["publication_date"], 
                              Columns["is_done"], 
                              Values["title"], 
                              Values["text"], 
                              Values["publication_date"]
                              ));
        }
    }
}
