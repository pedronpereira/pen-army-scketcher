using Newtonsoft.Json;
using System;

namespace PeNArmyScketcher.AgeOfSigmar.Converters
{
    public class UnitTypeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var unitType = reader.Value as string;

            return string.IsNullOrWhiteSpace(unitType) ? UnitType.Unit : Enum.Parse(typeof(UnitType), unitType, true);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}
