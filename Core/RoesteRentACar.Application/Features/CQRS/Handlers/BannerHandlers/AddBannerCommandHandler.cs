using RoesteRentACar.Application.Features.CQRS.Commands.BannerCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class AddBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public AddBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddBannerCommand command)
        {
            await _repository.AddAsync(new Banner
            {
                Title = command.Title,
                Description = command.Description,
                VideoUrl = command.VideoUrl,
                VideoDescription = command.VideoDescription
            });
        }
    }
}
