using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.TagCloudQueries;
using RoesteRentACar.Application.Features.Mediator.Results.TagCloudResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudQueryHandler: IRequestHandler<GetTagCloudQuery, List<GetTagCloudQueryResult>>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudQueryResult>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Select(x => new GetTagCloudQueryResult
                {
                    Id = x.Id,
                    BlogId = x.BlogId,
                    Title = x.Title 
                }).ToListAsync(cancellationToken);
        }
    }
}
