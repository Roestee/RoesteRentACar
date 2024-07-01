using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.BlogCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler: IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = await _repository.GetByIdAsync(request.Id, cancellationToken);
            blog.Name = request.Name;
            blog.BackgroundImageUrl = request.BackgroundImageUrl;
            blog.Content = request.Content;
            blog.CreateDate = request.CreateDate;

            await _repository.UpdateAsync(blog, cancellationToken);
        }
    }
}
