using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.LocationCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class AddLocationCommandHandler : IRequestHandler<AddLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public AddLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Location
            {
                Name = request.Name
            } , cancellationToken);
        }
    }
}
