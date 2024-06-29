using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.FeatureResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery : IRequest<GetFeatureByIdQueryResult>
    {
        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
