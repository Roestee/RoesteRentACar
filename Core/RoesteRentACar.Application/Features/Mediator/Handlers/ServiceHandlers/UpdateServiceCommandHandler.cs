using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.ServiceCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler: IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public UpdateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _repository.GetByIdAsync(request.Id, cancellationToken);
            service.Title = request.Title;
            service.Description = request.Description;
            service.IconUrl = request.IconUrl;

            await _repository.UpdateAsync(service, cancellationToken);
        }
    }
}
