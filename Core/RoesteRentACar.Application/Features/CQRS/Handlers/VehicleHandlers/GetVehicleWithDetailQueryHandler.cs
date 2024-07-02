using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.CQRS.Results.VehicleResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers
{
    public class GetVehicleWithDetailQueryHandler
    {
        private readonly IRepository<Vehicle> _repository;

        public GetVehicleWithDetailQueryHandler(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetVehicleWithDetailQueryResult>> Handle()
        {
            var values = await _repository.GetAllQueryable()
                .Include(x=>x.Brand)
                .Include(x=>x.VehiclePricing)
                .ThenInclude(x=>x.Pricing)
                .Select(x=>new GetVehicleWithDetailQueryResult
                {
                    Id = x.Id,
                    BrandId = x.BrandId,
                    BrandName = x.Brand.Name,
                    BigImageUrl = x.BigImageUrl,
                    CoverImageUrl = x.CoverImageUrl,
                    Fuel = x.Fuel,
                    Km = x.Km,
                    Luggage = x.Luggage,
                    Model = x.Model,
                    Seat = x.Seat,
                    Transmission = x.Transmission,
                    PricingName = "Günlük",
                    PricingAmount = x.VehiclePricing.FirstOrDefault(v=>v.Pricing.Name == "Günlük")!.Amount
                }).ToListAsync();

            return values;
        }
    }
}
