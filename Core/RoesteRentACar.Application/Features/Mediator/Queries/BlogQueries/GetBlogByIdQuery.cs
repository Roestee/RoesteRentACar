using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.BlogResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQuery: IRequest<GetBlogByIdQueryResult>
    {
        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
