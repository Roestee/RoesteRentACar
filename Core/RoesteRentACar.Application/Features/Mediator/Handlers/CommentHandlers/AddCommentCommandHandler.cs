using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.CommentCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class AddCommentCommandHandler: IRequestHandler<AddCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public AddCommentCommandHandler(IRepository<Comment> repository) => _repository = repository;

        public async Task Handle(AddCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Comment
            {
                Name = request.Name,
                BlogId = request.BlogId,
                Content = request.Content,
                CreateDate = request.CreateDate,
            }, cancellationToken);
        }
    }
}
