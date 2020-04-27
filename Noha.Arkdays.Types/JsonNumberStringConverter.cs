using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Noha.Arkdays.Types
{
    public class JsonNumberStringConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var str = reader.GetString();
            return Convert.ToInt32(str);
        }

        public override void Write(Utf8JsonWriter writer, [DisallowNull] int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(Convert.ToString(value));
        }
    }
}