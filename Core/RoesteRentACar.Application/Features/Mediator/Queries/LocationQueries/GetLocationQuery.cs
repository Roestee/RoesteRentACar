using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.LocationResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}
