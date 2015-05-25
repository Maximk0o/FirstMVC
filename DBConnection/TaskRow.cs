using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection {
    public class TaskRow {
        public int id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public DateTime publication_date { get; set; }
        public DateTime start_date { get; set; }
        public DateTime finish_date { get; set; }
        public bool is_done { get; set; }
    }
}
