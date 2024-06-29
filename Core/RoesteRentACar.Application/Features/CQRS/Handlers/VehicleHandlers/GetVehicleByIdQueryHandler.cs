using RoesteRentACar.Application.Features.CQRS.Queries.VehicleQueries;
using RoesteRentACar.Application.Features.CQRS.Results.VehicleResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers
{
    public class GetVehicleByIdQueryHandler
    {
        private readonly IRepository<Vehicle> _repository;

        public GetVehicleByIdQueryHandler(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public async Task<GetVehicleByIdQueryResult> Handle(GetVehicleByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetVehicleByIdQueryResult
            {
                Id = value.Id,
                BrandId = value.BrandId,
                BigImageUrl = value.BigImageUrl,
                CoverImageUrl = value.CoverImageUrl,
                Fuel = value.Fuel,
                Km = value.Km,
                Luggage = value.Luggage,
                Model = value.Model,
                Seat = value.Seat,
                Transmission = value.Transmission
            };
        }
    }
}
