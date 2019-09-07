using AwareGroup.SenseCAP.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwareGroup.SenseCAP.Models
{
    public abstract class DeviceBase
    {
        [JsonProperty("dev_eui")]
        public string DeviceEUI { get; set; }
        [JsonProperty("dev_name")]
        public string DeviceName { get; set; }
        [JsonProperty("dev_area")]
        public string DeviceArea { get; set; }
        [JsonProperty("dev_country")]
        public string DeviceCountry { get; set; }

        [JsonProperty("online_status")]
        public int OnlineStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }


        [JsonProperty("activate_time")]
        [JsonConverter(typeof(EpochDateTimeOffsetJsonConverter))]
        public DateTimeOffset TimestampLastActivated { get; set; }

        [JsonProperty("latestmsg_time")]
        [JsonConverter(typeof(EpochDateTimeOffsetJsonConverter))]
        public DateTimeOffset TimestampLastMessageReceived { get; set; }

        [JsonProperty("production_time")]
        [JsonConverter(typeof(EpochDateTimeOffsetJsonConverter))]
        public DateTimeOffset TimestampManufactured { get; set; }


        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("ver_hardware")]
        public string VersionHardware { get; set; }
        [JsonProperty("ver_software")]
        public string VersionSoftware { get; set; }
    }
}
