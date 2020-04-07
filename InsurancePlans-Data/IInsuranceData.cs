using InsurancePlans_Core;

namespace InsurancePlans_Data
{
    public partial class InsurancePlansData
    {
        public interface IInsuranceData
        {
            public Lead GetLead();
            public bool SaveLead();
        }
    }
}