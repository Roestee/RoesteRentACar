using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.AuthorCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class DeleteAuthorCommandHandler: IRequestHandler<DeleteAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public DeleteAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.Id, cancellationToken),
                cancellationToken);
        }
    }
}
