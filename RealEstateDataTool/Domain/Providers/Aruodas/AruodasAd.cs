namespace RealEstateDataTool.Domain
{
    public class AruodasAd
    {

        public Guid Id { get; set; }
        public DateTime InitialDateCollected { get; set; }
        public DateTime? DateRemoved { get; set; }
        public bool IsActive { get; set; }
        public Property Property { get; set; }
        public List<string> Pseudonyms { get; set; }

        public AruodasAd(Guid id, DateTime initialDateCollected)
        {
            Id = id;
            InitialDateCollected = initialDateCollected;
        }
    }
}
