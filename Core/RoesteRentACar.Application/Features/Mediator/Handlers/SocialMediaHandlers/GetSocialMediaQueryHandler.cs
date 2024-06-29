using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.SocialMediaQueries;
using RoesteRentACar.Application.Features.Mediator.Results.SocialMediaResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler: IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Select(x => new GetSocialMediaQueryResult
                {
                    Id = x.Id,
                    Name = x.Name,
                    Icon = x.Icon,
                    Url = x.Url
                }).ToListAsync(cancellationToken);
        }
    }
}
