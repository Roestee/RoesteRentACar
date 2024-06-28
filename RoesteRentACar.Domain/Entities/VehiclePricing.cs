namespace RoesteRentACar.Domain.Entities
{
    public class VehiclePricing
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int PricingId { get; set; }
        public decimal Amount { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        public virtual Pricing Pricing{ get; set; }
    }
}
