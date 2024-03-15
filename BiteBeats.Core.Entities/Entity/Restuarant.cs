namespace BiteBeats.Core.Entities.Entity
{
    public class Restuarant : BaseDbEntity
    {
        public string Name { get; set; }
        public string TagLine { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPhoneNumber { get; set; }
        public string PanNumber { get; set; }
        public string PanImage { get; set; }
        public string GstNumber { get; set; }
        public string GstImage { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PinCode { get; set; }
        public string OwnerId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public TimeSpan? OpeningHours { get; set; }
        public TimeSpan? ClosingHours { get; set; }
        public int DeliveryRadius { get; set; }
    }
}
