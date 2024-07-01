using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.BlogCommands
{
    public class DeleteBlogCommand: IRequest
    {
        public DeleteBlogCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
