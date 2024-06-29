using RoesteRentACar.Application.Features.CQRS.Commands.ContactCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class DeleteContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public DeleteContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteContactCommand command)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(command.Id));
        }
    }
}
