namespace RoesteRentACar.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual List<VehicleFeature>? VehicleFeatures { get; set; }
        public virtual List<VehicleDescription>? VehicleDescriptions { get; set; }
        public virtual List<VehiclePricing> VehiclePricing { get; set; }
    }
}
