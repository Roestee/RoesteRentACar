using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogWithDetailWithCountQuery: IRequest<List<GetBlogWithDetailWithCountQueryResult>>
    {
        public GetBlogWithDetailWithCountQuery(int count)
        {
            Count = count;
        }

        public int Count { get; private set; }
    }
}
