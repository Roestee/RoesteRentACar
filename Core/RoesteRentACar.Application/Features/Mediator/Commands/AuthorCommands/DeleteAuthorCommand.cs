using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.AuthorCommands
{
    public class DeleteAuthorCommand: IRequest
    {
        public DeleteAuthorCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
