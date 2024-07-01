using MediatR;
using RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler: IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return new GetBlogByIdQueryResult
            {
                Id = value.Id,
                AuthorId = value.AuthorId,
                CategoryId = value.CategoryId,
                BackgroundImageUrl = value.BackgroundImageUrl,
                Name = value.Name,
                Content = value.Content,
                CreateDate = value.CreateDate
            };
        }
    }
}
