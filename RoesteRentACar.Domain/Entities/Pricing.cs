namespace RoesteRentACar.Domain.Entities
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<VehiclePricing> VehiclePricing { get; set; }
    }
}
