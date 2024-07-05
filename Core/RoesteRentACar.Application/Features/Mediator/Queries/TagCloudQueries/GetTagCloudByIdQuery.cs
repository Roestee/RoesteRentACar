using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.TagCloudResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIdQuery: IRequest<GetTagCloudByIdQueryResult>
    {
        public GetTagCloudByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
