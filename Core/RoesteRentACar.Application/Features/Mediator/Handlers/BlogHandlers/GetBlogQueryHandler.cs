using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogQueryHandler: IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Select(x => new GetBlogQueryResult
                {
                    Id = x.Id,
                    Name = x.Name,
                    AuthorId = x.AuthorId,
                    CategoryId = x.CategoryId,
                    BackgroundImageUrl = x.BackgroundImageUrl,
                    Content = x.Content,
                    CreateDate = x.CreateDate
                }).ToListAsync(cancellationToken);
        }
    }
}
