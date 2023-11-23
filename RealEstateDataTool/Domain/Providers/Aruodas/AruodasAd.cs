namespace RealEstateDataTool.Domain
{
    public class AruodasAd
    {
        public Guid Id { get; set; }
        public DateTime InitialDateCollected { get; set; }
        public DateTime? DateRemoved { get; set; }
        public bool IsActive { get; set; }
        public Property Property { get; set; }
    }
}
