using RoesteRentACar.Application.Features.CQRS.Commands.AboutCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class DeleteAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public DeleteAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteAboutCommand aboutCommand)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(aboutCommand.Id));
        }
    }
}
