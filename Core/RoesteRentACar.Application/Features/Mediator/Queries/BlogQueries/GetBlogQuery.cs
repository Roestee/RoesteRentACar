using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogQuery: IRequest<List<GetBlogQueryResult>>
    {
    }
}
