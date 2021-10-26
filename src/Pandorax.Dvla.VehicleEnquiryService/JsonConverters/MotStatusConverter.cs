using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.Dvla.VehicleEnquiryService.Models;

namespace Pandorax.Dvla.VehicleEnquiryService.JsonConverters
{
    internal class MotStatusConverter : JsonConverter<MotStatus?>
    {
        public override MotStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();

            if (value is null)
            {
                return null;
            }

            return value switch
            {
                "No details held by DVLA" => MotStatus.NoDetailsHeldByDvla,
                "No results returned" => MotStatus.NoResultsReturned,
                "Not valid" => MotStatus.NotValid,
                "Valid" => MotStatus.Valid,
                _ => throw new NotSupportedException(),
            };
        }

        public override void Write(Utf8JsonWriter writer, MotStatus? value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                MotStatus.NoDetailsHeldByDvla => "No details held by DVLA",
                MotStatus.NoResultsReturned => "No results returned",
                MotStatus.NotValid => "Not valid",
                MotStatus.Valid => "Valid",
                null => null,
                _ => throw new NotSupportedException()
            };

            if (stringValue is not null)
            {
                writer.WriteStringValue(stringValue);
            }
        }
    }
}
