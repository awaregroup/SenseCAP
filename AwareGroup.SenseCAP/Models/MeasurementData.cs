using System.Collections.Generic;
using Newtonsoft.Json;

namespace AwareGroup.SenseCAP.Models
{
    public class MeasurementData
    {
        [JsonProperty("channel")]
        public int Channel { get; set; }

        [JsonProperty("points")]
        public List<Measurement> Points { get; set; }
    }
}
