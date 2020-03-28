using InsurancePlansNetCoreData.Models;
using InsurnacePlansNetCore_data.Models;
using Microsoft.EntityFrameworkCore;

namespace InsurancePlansNetCore_data.DataAccess
{
    public class InsuranceContext: DbContext
    {
        public InsuranceContext(DbContextOptions options): base(options){}
        
        public DbSet<Auto> Auto { get; set; }
        public DbSet<AutoBrand> AutoBrand { get; set; }
        public DbSet<AutoModel> AutoModel { get; set; }
        public DbSet<AutoTrim> AutoTrim { get; set; }
        public DbSet<FamilyMember> FamilyMember { get; set; }
        public DbSet<FamilyMemberType> FamilyMemberType { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Health> Health { get; set; }
        public DbSet<HealthPlanTerm> HealthPlanTerms { get; set; }
        public DbSet<HealthReason> HealthReason { get; set; }
        public DbSet<Home> Home { get; set; }
        public DbSet<HomeCloseToFireStation> HomeCloseToFireStation { get; set; }
        public DbSet<HomeFoundationType> HomeFoundationType { get; set; }
        public DbSet<HomeFrameType> HomeFrameType { get; set; }
        public DbSet<HomeHeatingSystem> HomeHeatingSystem { get; set; }
        public DbSet<HomeOwn> HomeOwn { get; set; }
        public DbSet<HomePropertyType> HomePropertyType { get; set; }
        public DbSet<HomeRoofMaterial> HomeRoofMaterial { get; set; }
        public DbSet<InsuranceService> InsuranceService { get; set; }
        public DbSet<Lead> Lead { get; set; }
        public DbSet<Medicare> Medicare { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}