using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.ServiceResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery: IRequest<GetServiceByIdQueryResult>
    {
        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
