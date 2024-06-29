using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.FooterAddressCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class AddFooterAddressCommandHandler : IRequestHandler<AddFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public AddFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new FooterAddress
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone
            }, cancellationToken);
        }
    }
}
