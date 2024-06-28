using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.CQRS.Commands.AboutCommands;
using RoesteRentACar.Application.Features.CQRS.Handlers.AboutHandlers;
using RoesteRentACar.Application.Features.CQRS.Queries.AboutQueries;

namespace RoesteRentACar.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly GetAboutQueryHandler _getAboutQueryHandler;
        private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly AddAboutCommandHandler _addAboutCommandHandler;
        private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;
        private readonly DeleteAboutCommandHandler _deleteAboutCommandHandler;

        public AboutsController(
            GetAboutQueryHandler getAboutQueryHandler, 
            GetAboutByIdQueryHandler getAboutByIdQueryHandler, 
            AddAboutCommandHandler addAboutCommandHandler, 
            UpdateAboutCommandHandler updateAboutCommandHandler, 
            DeleteAboutCommandHandler deleteAboutCommandHandler)
        {
            _getAboutQueryHandler = getAboutQueryHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _addAboutCommandHandler = addAboutCommandHandler;
            _updateAboutCommandHandler = updateAboutCommandHandler;
            _deleteAboutCommandHandler = deleteAboutCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddAbout(AddAboutCommand command)
        {
            await _addAboutCommandHandler.Handle(command);
            return Ok("Hakkımda başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand aboutCommand)
        {
            await _updateAboutCommandHandler.Handle(aboutCommand);
            return Ok("Hakkımda başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _deleteAboutCommandHandler.Handle(new DeleteAboutCommand(id));
            return Ok("Hakkımda başarıyla silindi.");
        }
    }
}
