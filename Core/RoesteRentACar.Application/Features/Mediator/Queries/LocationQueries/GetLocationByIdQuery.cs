using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.LocationResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationByIdQuery: IRequest<GetLocationByIdQueryResult>
    {
        public GetLocationByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
