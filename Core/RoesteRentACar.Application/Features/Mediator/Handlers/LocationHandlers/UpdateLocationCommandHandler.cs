using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.LocationCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class UpdateLocationCommandHandler: IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public UpdateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var location = await _repository.GetByIdAsync(request.Id, cancellationToken);
            location.Name = request.Name;

            await _repository.UpdateAsync(location, cancellationToken);
        }
    }
}
