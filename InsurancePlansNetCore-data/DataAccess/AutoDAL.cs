using Microsoft.Extensions.Configuration;

namespace InsurancePlansNetCore_data.DataAccess
{
    public class AutoDAL
    {
        private string _connectionString;

        public AutoDAL(IConfiguration iConfiguration)
        {
            _connectionString = iConfiguration.GetConnectionString("insurancePlans");
        }
    }
}