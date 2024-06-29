using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.PricingCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class AddPricingCommandHandler: IRequestHandler<AddPricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public AddPricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddPricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Pricing{Name = request.Name}, cancellationToken);
        }
    }
}
