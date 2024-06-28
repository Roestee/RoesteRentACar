using RoesteRentACar.Application.Features.CQRS.Commands.AboutCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class AddAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public AddAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddAboutCommand addAboutCommand)
        {
            await _repository.AddAsync(new About
            {
                Title = addAboutCommand.Title,
                Description = addAboutCommand.Description,
                ImageUrl = addAboutCommand.ImageUrl
            });
        }
    }
}
