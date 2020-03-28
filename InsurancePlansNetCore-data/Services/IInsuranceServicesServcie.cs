using System.Collections.Generic;
using InsurancePlansNetCoreData.Models;

namespace InsurancePlansNetCoreData.Services
{
    public interface IInsuranceServicesServcie
    {
        public List<InsuranceService> GetInsuranceService();
    }
}