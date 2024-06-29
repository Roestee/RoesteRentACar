using RoesteRentACar.Application.Features.CQRS.Commands.ContactCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class AddContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public AddContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddContactCommand command)
        {
            await _repository.AddAsync(new Contact
            {
                Name = command.Name,
                Email = command.Email,
                Message = command.Message,
                SendDate = command.SendDate,
                Subject = command.Subject
            });
        }
    }
}
