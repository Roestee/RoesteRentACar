using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.CommentCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class UpdateCommentCommandHandler: IRequestHandler<UpdateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public UpdateCommentCommandHandler(IRepository<Comment> repository) => _repository = repository;

        public async Task Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = await _repository.GetByIdAsync(request.Id, cancellationToken);
            comment.Name = request.Name;
            comment.BlogId = request.BlogId;
            comment.Content = request.Content;
            comment.CreateDate = request.CreateDate;

            await _repository.UpdateAsync(comment, cancellationToken);
        }
    }
}
