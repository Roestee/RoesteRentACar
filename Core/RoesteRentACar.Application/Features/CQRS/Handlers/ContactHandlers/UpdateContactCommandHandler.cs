using RoesteRentACar.Application.Features.CQRS.Commands.ContactCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var contact = await _repository.GetByIdAsync(command.Id);
            contact.Email = command.Email;
            contact.Message = command.Message;
            contact.Name = command.Name;
            contact.SendDate = command.SendDate;
            contact.Subject = command.Subject;

            await _repository.UpdateAsync(contact);
        }
    }
}
