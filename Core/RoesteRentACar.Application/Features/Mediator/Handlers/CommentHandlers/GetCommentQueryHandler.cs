using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.CommentQueries;
using RoesteRentACar.Application.Features.Mediator.Results.CommentResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentQueryHandler: IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
    {
        private readonly IRepository<Comment> _repository;

        public GetCommentQueryHandler(IRepository<Comment> repository) =>_repository = repository;
        
        public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Select(x => new GetCommentQueryResult
                {
                    Id = x.Id,
                    BlogId = x.BlogId,
                    Name = x.Name,
                    Content = x.Content,
                    CreateDate = x.CreateDate
                }).ToListAsync(cancellationToken);
        }
    }
}
