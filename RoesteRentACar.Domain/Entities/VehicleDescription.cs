namespace RoesteRentACar.Domain.Entities
{
    public class VehicleDescription
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Detail { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
