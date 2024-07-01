using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.BlogCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public DeleteBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.Id, cancellationToken),
                cancellationToken);
        }
    }
}
