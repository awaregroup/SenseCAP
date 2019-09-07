using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwareGroup.SenseCAP.JsonConverters
{
    public class EpochDateTimeOffsetJsonConverter : JsonConverter
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var inputString = (string)reader.Value;
            var input = Convert.ToInt64(inputString);

            //create date from epoch
            var date = epoch.AddMilliseconds(input);

            //build new DateTimeOffset object with correct offset
            var timezone = TimeZoneInfo.Utc;
            var ret = new DateTimeOffset(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, date.Millisecond, timezone.BaseUtcOffset);

            return ret;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTimeOffset);
        }
    }
}
