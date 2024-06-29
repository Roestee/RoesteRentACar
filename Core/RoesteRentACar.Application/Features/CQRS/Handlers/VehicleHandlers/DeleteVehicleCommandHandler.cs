using RoesteRentACar.Application.Features.CQRS.Commands.VehicleCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers
{
    public class DeleteVehicleCommandHandler
    {
        private readonly IRepository<Vehicle> _repository;

        public DeleteVehicleCommandHandler(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteVehicleCommand command)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(command.Id));
        }
    }
}
