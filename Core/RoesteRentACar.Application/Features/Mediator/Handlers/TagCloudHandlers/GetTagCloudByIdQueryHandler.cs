using MediatR;
using RoesteRentACar.Application.Features.Mediator.Queries.TagCloudQueries;
using RoesteRentACar.Application.Features.Mediator.Results.TagCloudResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByIdQueryHandler: IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return new GetTagCloudByIdQueryResult
            {
                Id = value.Id,
                BlogId = value.BlogId,
                Title = value.Title
            };
        }
    }
}
