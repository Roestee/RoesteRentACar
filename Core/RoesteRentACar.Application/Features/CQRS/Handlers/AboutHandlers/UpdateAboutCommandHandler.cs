using RoesteRentACar.Application.Features.CQRS.Commands.AboutCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand aboutCommand)
        {
            var value = await _repository.GetByIdAsync(aboutCommand.Id);
            value.Title = aboutCommand.Title;
            value.Description = aboutCommand.Description;
            value.ImageUrl = aboutCommand.ImageUrl;

            await _repository.UpdateAsync(value);
        }
    }
}
