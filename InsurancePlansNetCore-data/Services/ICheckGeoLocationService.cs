using System.Threading.Tasks;

namespace InsurancePlansNetCoreData.Services
{
    public interface ICheckGeoLocationService
    {
        public Task<bool> CheckGeoLocationZipCode(string zipCode);
    }
}