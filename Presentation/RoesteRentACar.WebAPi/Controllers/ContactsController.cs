using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.CQRS.Commands.ContactCommands;
using RoesteRentACar.Application.Features.CQRS.Handlers.ContactHandlers;
using RoesteRentACar.Application.Features.CQRS.Queries.ContactQueries;

namespace RoesteRentACar.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly GetContactQueryHandler _getContactQueryHandler;
        private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
        private readonly AddContactCommandHandler _addContactCommandHandler;
        private readonly DeleteContactCommandHandler _deleteContactCommandHandler;
        private readonly UpdateContactCommandHandler _updateContactCommandHandler;

        public ContactsController(
            GetContactQueryHandler getContactQueryHandler, 
            GetContactByIdQueryHandler getContactByIdQueryHandler,
            AddContactCommandHandler addContactCommandHandler, 
            DeleteContactCommandHandler deleteContactCommandHandler,
            UpdateContactCommandHandler updateContactCommandHandler)
        {
            _getContactQueryHandler = getContactQueryHandler;
            _getContactByIdQueryHandler = getContactByIdQueryHandler;
            _addContactCommandHandler = addContactCommandHandler;
            _deleteContactCommandHandler = deleteContactCommandHandler;
            _updateContactCommandHandler = updateContactCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _getContactQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await _getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactCommand command)
        {
            await _addContactCommandHandler.Handle(command);
            return Ok("İletişim başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _deleteContactCommandHandler.Handle(new DeleteContactCommand(id));
            return Ok("İletişim başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await _updateContactCommandHandler.Handle(command);
            return Ok("İletişim başarıyla güncellendi.");
        }
    }
}
