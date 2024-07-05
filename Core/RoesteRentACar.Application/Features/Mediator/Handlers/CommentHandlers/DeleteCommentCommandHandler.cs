using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.CommentCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class DeleteCommentCommandHandler: IRequestHandler<DeleteCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public DeleteCommentCommandHandler(IRepository<Comment> repository) => _repository = repository;

        public async Task Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.Id, cancellationToken),
                cancellationToken);
        }
    }
}
