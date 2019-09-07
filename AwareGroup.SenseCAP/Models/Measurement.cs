using AwareGroup.SenseCAP.JsonConverters;
using Newtonsoft.Json;
using System;

namespace AwareGroup.SenseCAP.Models
{
    public class Measurement
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(EpochDateTimeOffsetJsonConverter))]
        public DateTimeOffset Timestamp{ get; set; }
    }
}