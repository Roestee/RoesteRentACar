using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.TagCloudResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudQuery: IRequest<List<GetTagCloudQueryResult>>
    {
    }
}
