namespace RoesteRentACar.Domain.Entities
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<VehicleFeature> VehicleFeatures { get; set; }
    }
}
