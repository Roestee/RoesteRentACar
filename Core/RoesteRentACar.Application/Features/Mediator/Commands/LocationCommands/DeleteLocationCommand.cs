using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.LocationCommands
{
    public class DeleteLocationCommand : IRequest
    {
        public DeleteLocationCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
