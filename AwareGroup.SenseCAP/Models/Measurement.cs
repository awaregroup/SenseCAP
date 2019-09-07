using System;

namespace AwareGroup.SenseCAP.Models
{
    public class Measurement
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public object Value { get; set; }
        public DateTimeOffset DateTimeCreated{ get; set; }
    }
}