using System.Threading.Tasks;
using Pandorax.Dvla.VehicleEnquiryService.Models;

namespace Pandorax.Dvla.VehicleEnquiryService
{
    /// <summary>
    /// <para>A service used to call and interact with the DVLA vehicle enquiry service.</para>
    /// <para>For more information visit: https://developer-portal.driver-vehicle-licensing.api.gov.uk/apis/vehicle-enquiry-service/vehicle-enquiry-service-description.html.</para>
    /// </summary>
    public interface IDvlaVehicleEnquiryService
    {
        /// <summary>
        /// Get the vehicle details for the supplied <paramref name="registrationNumber"/>
        /// </summary>
        /// <param name="registrationNumber"></param>
        /// <returns>
        /// A <see cref="Task"/> representing the current operation.
        /// </returns>
        Task<VehicleEnquiryResponse?> GetVehicleDetailsAsync(string registrationNumber);
    }
}
