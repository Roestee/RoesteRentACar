using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.BlogCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class AddBlogCommandHandler: IRequestHandler<AddBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public AddBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Blog
            {
                Name = request.Name,
                AuthorId = request.AuthorId,
                BackgroundImageUrl = request.BackgroundImageUrl,
                CategoryId = request.CategoryId,
                Content = request.Content,
                CreateDate = request.CreateDate
            }, cancellationToken);
        }
    }
}
