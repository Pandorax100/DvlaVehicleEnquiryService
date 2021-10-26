namespace Pandorax.Dvla.VehicleEnquiryService.Models
{
    internal class VehicleEnquiryRequest
    {
        public VehicleEnquiryRequest(string registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }

        public string RegistrationNumber { get; set; } = string.Empty;
    }
}
