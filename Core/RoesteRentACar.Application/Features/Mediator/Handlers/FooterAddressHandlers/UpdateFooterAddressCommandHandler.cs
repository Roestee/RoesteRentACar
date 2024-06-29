using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.FooterAddressCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler: IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var footerAddress = await _repository.GetByIdAsync(request.Id, cancellationToken);
            footerAddress.Address = request.Address;
            footerAddress.Description = request.Description;
            footerAddress.Email = request.Email;
            footerAddress.Phone = request.Phone;

            await _repository.UpdateAsync(footerAddress, cancellationToken);
        }
    }
}
