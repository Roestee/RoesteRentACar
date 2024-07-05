using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdWithDetailQueryHandler: IRequestHandler<GetBlogByIdWithDetailQuery, GetBlogByIdWithDetailQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdWithDetailQueryHandler(IRepository<Blog> repository) => _repository = repository;
        
        public async Task<GetBlogByIdWithDetailQueryResult> Handle(GetBlogByIdWithDetailQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Where(x => x.Id == request.Id)
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Select(x => new GetBlogByIdWithDetailQueryResult
                {
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    AuthorId = x.AuthorId,
                    AuthorDescription = x.Author.Description,
                    AuthorName = x.Author.Name,
                    AuthorImageUrl = x.Author.ImageUrl,
                    BackgroundImageUrl = x.BackgroundImageUrl,
                    CategoryName = x.Category.Name,
                    Content = x.Content,
                    CreateDate = x.CreateDate,
                    Name = x.Name
                }).FirstAsync(cancellationToken);
        }
    }
}
