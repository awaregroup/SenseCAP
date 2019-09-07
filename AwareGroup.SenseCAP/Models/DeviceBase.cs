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

        public DateTimeOffset DateTimeLastActivated { get; set; }
        public DateTimeOffset DateTimeLastMessageReceived { get; set; }
        public DateTimeOffset DateTimeManufactured { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        public string VersionHardware { get; set; }
        public string VersionSoftware { get; set; }
    }
}
