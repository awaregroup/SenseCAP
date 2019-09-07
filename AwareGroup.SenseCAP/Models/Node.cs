using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwareGroup.SenseCAP.Models
{
    public class Node : DeviceBase
    {
        /// <summary>
        /// True = Good, False = Bad
        /// </summary>
        [JsonProperty("battery_status")]
        public bool BatteryStatus { get; set; }

        [JsonProperty("msg_count")]
        public int MessageCount { get; set; }
    }
}
