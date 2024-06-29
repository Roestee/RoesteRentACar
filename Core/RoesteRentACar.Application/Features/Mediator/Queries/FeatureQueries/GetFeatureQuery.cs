using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.FeatureResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
    {
    }
}
