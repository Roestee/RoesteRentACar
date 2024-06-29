using RoesteRentACar.Application.Features.CQRS.Results.VehicleResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers
{
    public class GetVehicleQueryHandler
    {
        private readonly IRepository<Vehicle> _repository;

        public GetVehicleQueryHandler(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetVehicleQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetVehicleQueryResult
            {
                Id = x.Id,
                BrandId = x.BrandId,
                BigImageUrl = x.BigImageUrl,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}
