using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Models
{
    public class JsonData
    {
        [JsonProperty("names")]
        public List<string> Names { get; set; }

        [JsonProperty("devices")]
        public List<string> Devices { get; set; }
    }
}
