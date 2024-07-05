using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.TagCloudResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudsByBlogIdQuery : IRequest<List<GetTagCloudByFilterQueryResult>>
    {
        public GetTagCloudsByBlogIdQuery(int blogId)
        {
            BlogId = blogId;
        }

        public int BlogId { get; private set; }
    }
}
