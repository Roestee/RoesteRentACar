using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.CommentCommands
{
    public class UpdateCommentCommand: IRequest
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
