using MediatR;
using RoesteRentACar.Application.Features.Mediator.Queries.CommentQueries;
using RoesteRentACar.Application.Features.Mediator.Results.CommentResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentByIdQueryHandler: IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueryResult>
    {
        private readonly IRepository<Comment> _repository;

        public GetCommentByIdQueryHandler(IRepository<Comment> repository) => _repository = repository;

        public async Task<GetCommentByIdQueryResult> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return new GetCommentByIdQueryResult
            {
                Id = value.Id,
                BlogId = value.BlogId,
                Content = value.Content,
                CreateDate = value.CreateDate,
                Name = value.Name
            };
        }
    }
}
