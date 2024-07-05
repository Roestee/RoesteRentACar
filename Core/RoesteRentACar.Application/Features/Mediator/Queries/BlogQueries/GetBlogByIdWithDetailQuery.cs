using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdWithDetailQuery: IRequest<GetBlogByIdWithDetailQueryResult>
    {
        public GetBlogByIdWithDetailQuery(int id) => Id = id;

        public int Id { get; private set; }
    }
}
