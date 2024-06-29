using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.ServiceResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}
