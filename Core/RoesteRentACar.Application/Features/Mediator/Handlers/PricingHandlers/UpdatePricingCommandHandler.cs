using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.PricingCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class UpdatePricingCommandHandler: IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public UpdatePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var pricing = await _repository.GetByIdAsync(request.Id, cancellationToken);
            pricing.Name = request.Name;

            await _repository.UpdateAsync(pricing, cancellationToken);
        }
    }
}
