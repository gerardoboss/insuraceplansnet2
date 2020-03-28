using System;

namespace InsurancePlansNetCoreData.Models
{
    public class FamilyMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public virtual Gender Gender{ get; set; }
        public bool TobaccoUse { get; set; }
        public DateTime Dob { get; set; }
        public int FamilyMemberTypeId { get; set; }
        public virtual FamilyMemberType FamilyMemberType { get; set; }
    }
}