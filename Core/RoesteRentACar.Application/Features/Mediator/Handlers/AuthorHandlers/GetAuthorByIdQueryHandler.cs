using MediatR;
using RoesteRentACar.Application.Features.Mediator.Queries.AuthorQueries;
using RoesteRentACar.Application.Features.Mediator.Results.AuthorResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler: IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return new GetAuthorByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                ImageUrl = value.ImageUrl
            };
        }
    }
}
