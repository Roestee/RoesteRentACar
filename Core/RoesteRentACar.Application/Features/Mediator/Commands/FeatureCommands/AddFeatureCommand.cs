using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.FeatureCommands
{
    public class AddFeatureCommand:IRequest
    {
        public string Name { get; set; }
    }
}
