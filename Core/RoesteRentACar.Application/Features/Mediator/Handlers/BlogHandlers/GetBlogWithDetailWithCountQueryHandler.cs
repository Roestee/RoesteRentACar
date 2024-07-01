using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithDetailWithCountQueryHandler: IRequestHandler<GetBlogWithDetailWithCountQuery, List<GetBlogWithDetailWithCountQueryResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogWithDetailWithCountQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogWithDetailWithCountQueryResult>> Handle(GetBlogWithDetailWithCountQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Include(x => x.Author)
                .Include(x => x.Category)
                .OrderByDescending(x => x.Id)
                .Take(request.Count)
                .Select(x => new GetBlogWithDetailWithCountQueryResult
                {
                    Id = x.Id,
                    AuthorId = x.AuthorId,
                    CategoryId = x.CategoryId,
                    Name = x.Name,
                    Content = x.Content,
                    CreateDate = x.CreateDate,
                    BackgroundImageUrl = x.BackgroundImageUrl,
                    AuthorName = x.Author.Name
                }).ToListAsync(cancellationToken);
        }
    }
}
