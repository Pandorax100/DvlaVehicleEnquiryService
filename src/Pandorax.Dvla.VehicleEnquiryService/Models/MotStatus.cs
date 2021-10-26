namespace Pandorax.Dvla.VehicleEnquiryService.Models
{
    /// <summary>
    /// The MOT Status of the vehicle
    /// </summary>
    public enum MotStatus
    {
        /// <summary>
        /// No details are held by the DVLA
        /// </summary>
        NoDetailsHeldByDvla,

        /// <summary>
        /// The API didn't return any MOT details
        /// </summary>
        NoResultsReturned,

        /// <summary>
        /// The MOT is not valid.
        /// </summary>
        NotValid,

        /// <summary>
        /// The MOT is valid.
        /// </summary>
        Valid,
    }
}
