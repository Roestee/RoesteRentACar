using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.PricingCommands
{
    public class AddPricingCommand: IRequest
    {
        public string Name { get; set; }
    }
}
