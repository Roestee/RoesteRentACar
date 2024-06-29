using RoesteRentACar.Application.Features.CQRS.Commands.VehicleCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers
{
    public class AddVehicleCommandHandler
    {
        private readonly IRepository<Vehicle> _repository;

        public AddVehicleCommandHandler(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddVehicleCommand command)
        {
            await _repository.AddAsync(new Vehicle
            {
                BrandId = command.BrandId,
                BigImageUrl = command.BigImageUrl,
                CoverImageUrl = command.CoverImageUrl,
                Fuel = command.Fuel,
                Km = command.Km,
                Luggage = command.Luggage,
                Model = command.Model,
                Seat = command.Seat,
                Transmission = command.Transmission
            });
        }
    }
}
