using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.Dvla.VehicleEnquiryService.Models;

namespace Pandorax.Dvla.VehicleEnquiryService.JsonConverters
{
    internal class TaxStatusConverter : JsonConverter<TaxStatus?>
    {
        public override TaxStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();

            if (value is null)
            {
                return null;
            }

            return value switch
            {
                "Not Taxed for on Road Use" => TaxStatus.NotTaxedForOnRoadUse,
                "SORN" => TaxStatus.Sorn,
                "Taxed" => TaxStatus.Taxed,
                "Untaxed" => TaxStatus.Untaxed,
                _ => throw new ArgumentOutOfRangeException(nameof(value)),
            };
        }

        public override void Write(Utf8JsonWriter writer, TaxStatus? value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                TaxStatus.NotTaxedForOnRoadUse => "Not Taxed for on Road Use",
                TaxStatus.Sorn => "SORN",
                TaxStatus.Taxed => "Taxed",
                TaxStatus.Untaxed => "Untaxed",
                null => null,
                _ => throw new ArgumentOutOfRangeException(nameof(value))
            };

            if (stringValue is not null)
            {
                writer.WriteStringValue(stringValue);
            }
        }
    }
}
