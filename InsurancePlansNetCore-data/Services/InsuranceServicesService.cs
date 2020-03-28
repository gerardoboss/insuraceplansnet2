using System;
using System.Collections.Generic;
using System.Linq;
using InsurancePlansNetCoreData.Models;

namespace InsurancePlansNetCoreData.Services
{
    public class InsuranceServicesService: IInsuranceServicesServcie
    {
        public List<InsuranceService> GetInsuranceService()
        {
            try
            {
                var services = new List<InsuranceService>
                {
                    new InsuranceService
                    {
                        Id = 1,
                        Name = "Health"
                    },
                    new InsuranceService
                    {
                        Id = 2,
                        Name = "Medicare"
                    },
                    new InsuranceService
                    {
                        Id = 3,
                        Name = "Auto"
                    },
                    new InsuranceService
                    {
                        Id = 4,
                        Name = "Home"
                    },
                    new InsuranceService
                    {
                        Id = 5,
                        Name = "Life"
                    }
                };
                var sortedServices = services.OrderBy(o => o.Name).ToList();
                return sortedServices;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}