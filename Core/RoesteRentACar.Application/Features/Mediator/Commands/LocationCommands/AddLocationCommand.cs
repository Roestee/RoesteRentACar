using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.LocationCommands
{
    public class AddLocationCommand : IRequest
    {
        public string Name { get; set; }
    }
}
