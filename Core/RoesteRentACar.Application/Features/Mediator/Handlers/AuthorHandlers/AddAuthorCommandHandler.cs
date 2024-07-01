using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.AuthorCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class AddAuthorCommandHandler: IRequestHandler<AddAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public AddAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Author
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            }, cancellationToken);
        }
    }
}
