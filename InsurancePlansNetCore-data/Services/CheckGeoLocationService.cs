using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace InsurancePlansNetCoreData.Services
{
    public class CheckGeoLocationService: ICheckGeoLocationService
    {
        public CheckGeoLocationService()
        {
        }

        public async Task<bool> CheckGeoLocationZipCode(string zipCode)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "https://bossppcservice.azurewebsites.net/api/Get_GeoLocation/?zipcode=" + zipCode;
                    var uri = new Uri(url);
                    var response = await httpClient.GetStringAsync(uri);
                    var geoResponse = response;
                    if (!string.IsNullOrEmpty(geoResponse))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}