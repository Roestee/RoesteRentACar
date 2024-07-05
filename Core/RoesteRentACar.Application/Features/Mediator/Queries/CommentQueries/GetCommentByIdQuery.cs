using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.CommentResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetCommentByIdQuery: IRequest<GetCommentByIdQueryResult>
    {
        public GetCommentByIdQuery(int id) => Id = id;
        
        public int Id { get; private set; }
    }
}
