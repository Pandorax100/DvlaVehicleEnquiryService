# DVLA Vehicle Enquiry Service

An API client to access the DVLA Vehicle Enquiry Service

The DVLA Vehicle Enquiry API is a RESTful service that provides vehicle details of a specified vehicle. It uses the vehicle registration number as input to search and provide details of the vehicle

For more information about the DVLA Vehicle Enquiry Service API visit [their website](https://developer-portal.driver-vehicle-licensing.api.gov.uk/apis/vehicle-enquiry-service/vehicle-enquiry-service-description.html#vehicle-enquiry-service-api)

## Getting started

### Get an API Key

In order to use this project an API key from the DVLA is required. For more information on how to obtain your API key visit the [DVLA website](https://developer-portal.driver-vehicle-licensing.api.gov.uk/apis/vehicle-enquiry-service/vehicle-enquiry-service-description.html#vehicle-enquiry-service-api)

### Configure the service

In your startup class add the DVLA Vehicle Enquiry Service

```cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddDvlaVehicleEnquiryService(Configuration["DvlaApiKey"]);
}
```

### Using the service

Inject the DVLA vehicle enquiry into your class in order to use it.

```cs
public class CarService
{
    private readonly IDvlaVehicleEnquiryService _vehicleEnquiryService;

    public CarService(IDvlaVehicleEnquiryService vehicleEnquiryService)
    {
        _vehicleEnquiryService = vehicleEnquiryService;
    }
}
```

```cs
 VehicleEnquiryResponse vehicleDetails = await _vehicleEnquiryService.GetVehicleDetailsAsync(RegistrationNumber);
```
