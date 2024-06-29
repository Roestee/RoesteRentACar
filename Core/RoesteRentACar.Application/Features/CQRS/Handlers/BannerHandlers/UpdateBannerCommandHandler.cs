using RoesteRentACar.Application.Features.CQRS.Commands.BannerCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            value.Title = command.Title;
            value.Description = command.Description;
            value.VideoUrl = command.VideoUrl;
            value.VideoDescription = command.VideoDescription;

            await _repository.UpdateAsync(value);
        }
    }
}
