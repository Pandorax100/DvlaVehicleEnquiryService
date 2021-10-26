using System;
using Microsoft.Extensions.DependencyInjection;

namespace Pandorax.Dvla.VehicleEnquiryService
{
    /// <summary>
    /// A class containing helper extension methods to add the DVLA vehicle enquiry service to the service collection.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        ///     <para>
        ///         Registers the DVLA vehicle enquiry service in the <see cref="IServiceCollection"/>
        ///     </para>
        ///     <para>
        ///         Use this method when using dependency injection in your application, such as with ASP.NET Core.
        ///         For applications that don't use dependency injection, consider creating <see cref="DvlaVehicleEnquiryService" />
        ///         instances directly with its constructor.
        ///     </para>
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
        /// <param name="apiKey">
        /// <para>Your API key for the DVLA vehicle enquiry service.</para>
        /// <para>If you do not have an api key one can be obtained from the DVLA website</para>
        /// </param>
        /// <returns></returns>
        public static IServiceCollection AddDvlaVehicleEnquiryService(this IServiceCollection services, string apiKey)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (apiKey is null)
            {
                throw new ArgumentNullException(nameof(apiKey));
            }

            services.AddHttpClient<IDvlaVehicleEnquiryService, DvlaVehicleEnquiryService>(client =>
            {
                client.BaseAddress = new Uri(Options.VehicleEnquiryServiceOptions.BaseUrl);

                client.DefaultRequestHeaders.Add("x-api-key", apiKey);
            });

            return services;
        }
    }
}
