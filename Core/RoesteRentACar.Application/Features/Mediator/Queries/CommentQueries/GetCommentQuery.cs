using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.CommentResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetCommentQuery: IRequest<List<GetCommentQueryResult>>
    {
    }
}
