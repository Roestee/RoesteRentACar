using MediatR;
using RoesteRentACar.Application.Features.Mediator.Queries.SocialMediaQueries;
using RoesteRentACar.Application.Features.Mediator.Results.SocialMediaResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler: IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return new GetSocialMediaByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Icon = value.Icon,
                Url = value.Url
            };
        }
    }
}
