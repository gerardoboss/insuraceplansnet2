using System;

namespace InsurancePlansNetCoreData.Models
{
    public class Home
    {
        public int Id { get; set; }
        public int HomePropertyTypeId { get; set; }
        public virtual HomePropertyType HomePropertyType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public int YearOfConstruction { get; set; }
        public int HomeFoundationTypeId { get; set; }
        public virtual HomeFoundationType HomeFoundationType{ get; set; }
        public int HomeFrameTypeId { get; set; }
        public virtual HomeFrameType HomeFrameType { get; set; }
        public int PropertyStories { get; set; }
        public int HomeHeatingSystemId { get; set; }
        public virtual HomeHeatingSystem HomeHeatingSystem{ get; set; }
        public int HomeRoofMaterialId { get; set; }
        public virtual HomeRoofMaterial HomeRoofMaterial{ get; set; }
        public int RoofReplaced { get; set; }
        public decimal SquareFootage { get; set; }
        public decimal CostOfRebuild { get; set; }
        public bool FloodZone { get; set; }
        public bool HydrantClose { get; set; }
        public int HomeCloseToFireStationId { get; set; }
        public virtual HomeCloseToFireStation HomeCloseToFireStation{ get; set; }
        public int HomeOwnId { get; set; }
        public virtual HomeOwn HomeOwn{ get; set; }
    }
}