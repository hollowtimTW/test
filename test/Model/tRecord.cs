using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Model
{
    public class tRecord
    {
        public int RecordId { get; set; }
        public string Timestamp { get; set; }
        public string Person { get; set; }
        public string MaterialRequestNumber { get; set; }
        public string RepairRequestNumber { get; set; }
        public string Device { get; set; }
        public string Remarks { get; set; }
    }
}
