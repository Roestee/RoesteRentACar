using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.ServiceCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class AddServiceCommandHandler: IRequestHandler<AddServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public AddServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Service
            {
                Title = request.Title,
                Description = request.Description,
                IconUrl = request.IconUrl
            }, cancellationToken);
        }
    }
}
