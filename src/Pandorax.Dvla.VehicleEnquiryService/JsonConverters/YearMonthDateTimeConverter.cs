using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pandorax.Dvla.VehicleEnquiryService.JsonConverters
{
    internal class YearMonthDateTimeConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            return value is null ? null : DateTime.Parse(value);
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
