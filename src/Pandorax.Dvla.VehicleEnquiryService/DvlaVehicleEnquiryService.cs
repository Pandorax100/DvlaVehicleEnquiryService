using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Pandorax.Dvla.VehicleEnquiryService.JsonConverters;
using Pandorax.Dvla.VehicleEnquiryService.Models;

namespace Pandorax.Dvla.VehicleEnquiryService
{
    internal class DvlaVehicleEnquiryService : IDvlaVehicleEnquiryService
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new(JsonSerializerDefaults.Web)
        {
            Converters =
            {
                new MotStatusConverter(),
                new TaxStatusConverter(),
            }
        };

        private readonly HttpClient _httpClient;

        public DvlaVehicleEnquiryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public async Task<VehicleEnquiryResponse?> GetVehicleDetailsAsync(string registrationNumber)
        {
            if (string.IsNullOrWhiteSpace(registrationNumber))
            {
                throw new System.ArgumentException($"'{nameof(registrationNumber)}' cannot be null or whitespace.", nameof(registrationNumber));
            }

            var request = new VehicleEnquiryRequest(registrationNumber);
            var requestJson = JsonSerializer.Serialize(request, JsonSerializerOptions);

            var requestStringContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
            using var httpResponse = await _httpClient.PostAsync("/vehicle-enquiry/v1/vehicles", requestStringContent);

            if (httpResponse.IsSuccessStatusCode)
            {
                string responseJson = await httpResponse.Content.ReadAsStringAsync();
                VehicleEnquiryResponse? enquiryResponse = JsonSerializer.Deserialize<VehicleEnquiryResponse>(responseJson, JsonSerializerOptions);

                return enquiryResponse;
            }

            return null;
        }
    }
}
