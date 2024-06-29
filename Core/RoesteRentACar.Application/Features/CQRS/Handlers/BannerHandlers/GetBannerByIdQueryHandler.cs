using RoesteRentACar.Application.Features.CQRS.Queries.BannerQueries;
using RoesteRentACar.Application.Features.CQRS.Results.BannerResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                Title = value.Title,
                Description = value.Description,
                VideoUrl = value.VideoUrl,
                VideoDescription = value.VideoDescription
            };
        }
    }
}
