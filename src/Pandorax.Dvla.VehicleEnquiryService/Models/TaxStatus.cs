namespace Pandorax.Dvla.VehicleEnquiryService.Models
{
    /// <summary>
    /// The tax status of the vehicle.
    /// </summary>
    public enum TaxStatus
    {
        /// <summary>
        /// The vehicle is not taxed for on road use.
        /// </summary>
        NotTaxedForOnRoadUse,

        /// <summary>
        /// The vehicle is marked as SORN.
        /// </summary>
        Sorn,

        /// <summary>
        /// The vehicle is taxed.
        /// </summary>
        Taxed,

        /// <summary>
        /// The vehicle is untaxed.
        /// </summary>
        Untaxed,
    }
}
