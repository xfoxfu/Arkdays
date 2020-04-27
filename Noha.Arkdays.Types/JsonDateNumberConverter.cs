using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Noha.Arkdays.Types
{
    public class JsonDateNumberConverter : JsonConverter<DateTime>
    {
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.TryGetUInt64(out var val);
            return _epoch.AddSeconds(val);
        }

        public override void Write(Utf8JsonWriter writer, [DisallowNull] DateTime value, JsonSerializerOptions options)
        {
            try
            {
                writer.WriteNumberValue(Convert.ToUInt64(Math.Round(value.Subtract(_epoch).TotalSeconds)));
            }
            catch (Exception e)
            {
                writer.WriteNumberValue(0);
            }
        }
    }
}