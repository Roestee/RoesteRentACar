using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.ServiceCommands
{
    public class AddServiceCommand : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
