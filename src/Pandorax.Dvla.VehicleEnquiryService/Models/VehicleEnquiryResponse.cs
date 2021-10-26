using System;
using System.Text.Json.Serialization;
using Pandorax.Dvla.VehicleEnquiryService.JsonConverters;

namespace Pandorax.Dvla.VehicleEnquiryService.Models
{
    /// <summary>
    /// This class models the response from the vehicle enquiry API.
    /// </summary>
    public record VehicleEnquiryResponse
    {
        /// <summary>
        /// Registration number of the vehicle
        /// </summary>
        public string RegistrationNumber { get; init; } = string.Empty;

        /// <summary>
        /// Tax status of the vehicle
        /// </summary>
        public TaxStatus? TaxStatus { get; init; }

        /// <summary>
        /// Date of tax liability, Used in calculating licence information presented to user
        /// </summary>
        public DateTime? TaxDueDate { get; init; }

        /// <summary>
        /// Additional Rate of Tax End Date
        /// </summary>
        public DateTime? ArtEndDate { get; init; }

        /// <summary>
        /// MOT Status of the vehicle
        /// </summary>
        public MotStatus? MotStatus { get; init; }

        /// <summary>
        /// Mot Expiry Date
        /// </summary>
        public DateTime? MotExpiryDate { get; init; }

        /// <summary>
        /// The Vehicle Make
        /// </summary>
        public string? Make { get; init; }

        /// <summary>
        /// Month of First DVLA Registration
        /// </summary>
        [JsonConverter(typeof(YearMonthDateTimeConverter))]
        public DateTime? MonthOfFirstDvlaRegistration { get; init; }

        /// <summary>
        /// Month of First Registration
        /// </summary>
        [JsonConverter(typeof(YearMonthDateTimeConverter))]
        public DateTime? MonthOfFirstRegistration { get; init; }

        /// <summary>
        /// Year of Manufacture
        /// </summary>
        public int? YearOfManufacture { get; init; }

        /// <summary>
        /// Engine capacity in cubic centimetres
        /// </summary>
        public int? EngineCapacity { get; init; }

        /// <summary>
        /// Carbon Dioxide emissions in grams per kilometre
        /// </summary>
        public int? CO2Emissions { get; init; }

        /// <summary>
        /// Fuel type (Method of Propulsion)
        /// </summary>
        public string? FuelType { get; init; }

        /// <summary>
        /// True only if vehicle has been export marked
        /// </summary>
        public bool MarkedForExport { get; init; }

        /// <summary>
        /// Vehicle colour
        /// </summary>
        public string? Colour { get; init; }

        /// <summary>
        /// Vehicle Type Approval Category
        /// </summary>
        public string? TypeApproval { get; init; }

        /// <summary>
        /// Vehicle wheel plan
        /// </summary>
        public string? Wheelplan { get; init; }

        /// <summary>
        /// Revenue weight in kilograms
        /// </summary>
        public int? RevenueWeight { get; init; }

        /// <summary>
        /// Real Driving Emissions value
        /// </summary>
        public string? RealDrivingEmissions { get; init; }

        /// <summary>
        /// Date of last V5C issued
        /// </summary>
        public DateTime? DateOfLastV5CIssued { get; init; }

        /// <summary>
        /// Euro Status (Dealer / Customer Provided (new vehicles))
        /// </summary>
        public string? EuroStatus { get; init; }
    }
}
