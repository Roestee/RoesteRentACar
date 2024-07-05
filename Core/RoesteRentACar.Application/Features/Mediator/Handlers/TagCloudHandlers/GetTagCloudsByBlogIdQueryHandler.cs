using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.TagCloudQueries;
using RoesteRentACar.Application.Features.Mediator.Results.TagCloudResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudsByBlogIdQueryHandler: IRequestHandler<GetTagCloudsByBlogIdQuery, List<GetTagCloudByFilterQueryResult>>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudsByBlogIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudByFilterQueryResult>> Handle(GetTagCloudsByBlogIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Where(x=>x.BlogId == request.BlogId)
                .Select(x=> new GetTagCloudByFilterQueryResult
                {
                    Id = x.Id,
                    BlogId = x.BlogId,
                    Title = x.Title
                }).ToListAsync(cancellationToken);
        }
    }
}
