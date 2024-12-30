using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Model
{
    public class Record
    {
        public int RecordId { get; set; }
        [DisplayName("時間")]
        public string Timestamp { get; set; }
        [DisplayName("姓名")]
        public string Person { get; set; }
        [DisplayName("領料單號")]
        public string MaterialRequestNumber { get; set; }
        [DisplayName("報修單號")]
        public string RepairRequestNumber { get; set; }
        [DisplayName("領用設備")]
        public string Device { get; set; }
        [Browsable(false)]
        [DisplayName("備註")]
        public string Remarks { get; set; }
    }
}
