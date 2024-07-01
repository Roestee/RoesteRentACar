using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.AuthorResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery: IRequest<List<GetAuthorQueryResult>>
    {
    }
}
