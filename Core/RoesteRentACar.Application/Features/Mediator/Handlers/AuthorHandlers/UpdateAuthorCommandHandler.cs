using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.AuthorCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public UpdateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = await _repository.GetByIdAsync(request.Id, cancellationToken);
            author.Name = request.Name;
            author.Description = request.Description;
            author.ImageUrl = request.ImageUrl;

            await _repository.UpdateAsync(author, cancellationToken);
        }
    }
}
