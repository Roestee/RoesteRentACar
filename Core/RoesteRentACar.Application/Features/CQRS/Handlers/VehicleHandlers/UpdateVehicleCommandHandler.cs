using RoesteRentACar.Application.Features.CQRS.Commands.VehicleCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers
{
    public class UpdateVehicleCommandHandler
    {
        private readonly IRepository<Vehicle> _repository;

        public UpdateVehicleCommandHandler(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateVehicleCommand command)
        {
            var vehicle = await _repository.GetByIdAsync(command.Id);
            vehicle.BrandId = command.Id;
            vehicle.BigImageUrl = command.BigImageUrl;
            vehicle.CoverImageUrl = command.CoverImageUrl;
            vehicle.Fuel = command.Fuel;
            vehicle.Km = command.Km;
            vehicle.Luggage = command.Luggage;
            vehicle.Model = command.Model;
            vehicle.Seat = command.Seat;
            vehicle.Transmission = command.Transmission;

            await _repository.UpdateAsync(vehicle);
        }
    }
}
