namespace RoesteRentACar.Domain.Entities
{
    public class VehicleFeature
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int FeatureId { get; set; }
        public bool Available { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        public virtual Feature Feature { get; set; }
    }
}
