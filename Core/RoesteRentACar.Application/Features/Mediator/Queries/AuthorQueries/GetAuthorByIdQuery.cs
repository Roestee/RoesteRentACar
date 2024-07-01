using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.AuthorResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery: IRequest<GetAuthorByIdQueryResult>
    {
        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
