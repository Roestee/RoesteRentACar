using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithDetailQueryHandler: IRequestHandler<GetBlogWithDetailQuery, List<GetBlogWithDetailQueryResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogWithDetailQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogWithDetailQueryResult>> Handle(GetBlogWithDetailQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Include(x => x.Category)
                .Include(x => x.Author)
                .Select(x => new GetBlogWithDetailQueryResult
                {
                    Id = x.Id,
                    AuthorId = x.AuthorId,
                    Name = x.Name,
                    CategoryId = x.CategoryId,
                    BackgroundImageUrl = x.BackgroundImageUrl,
                    Content = x.Content,
                    CreateDate = x.CreateDate,
                    AuthorName = x.Author.Name
                }).ToListAsync(cancellationToken);
        }
    }
}
