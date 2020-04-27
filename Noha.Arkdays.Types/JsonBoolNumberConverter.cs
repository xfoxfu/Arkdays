using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Noha.Arkdays.Types
{
    public class JsonBoolNumberConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.TryGetUInt64(out var val);
            return val != 0;
        }

        public override void Write(Utf8JsonWriter writer, [DisallowNull] bool value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value ? 1 : 0);
        }
    }
}