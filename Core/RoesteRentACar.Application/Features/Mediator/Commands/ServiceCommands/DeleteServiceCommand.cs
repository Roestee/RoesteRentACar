using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.ServiceCommands
{
    public class DeleteServiceCommand : IRequest
    {
        public DeleteServiceCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
