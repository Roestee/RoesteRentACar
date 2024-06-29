using RoesteRentACar.Application.Features.CQRS.Results.BannerResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetBannerQueryResult
            {
                Title = x.Title,
                Description = x.Description,
                VideoUrl = x.VideoUrl,
                VideoDescription = x.VideoDescription
            }).ToList();
        }
    }
}
