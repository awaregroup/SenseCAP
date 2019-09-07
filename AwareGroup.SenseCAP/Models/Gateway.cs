using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwareGroup.SenseCAP.Models
{
    public class Gateway : DeviceBase
    {
        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("antenna_placement")]
        public string AntennaPlacement { get; set; }
    }
}
