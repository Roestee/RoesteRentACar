using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.PricingCommands
{
    public class DeletePricingCommand: IRequest
    {
        public DeletePricingCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
