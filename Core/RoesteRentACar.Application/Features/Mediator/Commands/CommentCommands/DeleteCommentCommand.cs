using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.CommentCommands
{
    public class DeleteCommentCommand: IRequest
    {
        public DeleteCommentCommand(int id) => Id = id;

        public int Id { get; private set; }
    }
}
