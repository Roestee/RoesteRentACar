using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.FooterAddressCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class DeleteFooterAddressCommandHandler : IRequestHandler<DeleteFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public DeleteFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.Id, cancellationToken), cancellationToken);
        }
    }
}
