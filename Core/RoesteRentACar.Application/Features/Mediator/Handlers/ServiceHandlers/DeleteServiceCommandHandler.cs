using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.ServiceCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class DeleteServiceCommandHandler: IRequestHandler<DeleteServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public DeleteServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.Id, cancellationToken), cancellationToken);
        }
    }
}
