using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.Mediator.Commands.AuthorCommands;
using RoesteRentACar.Application.Features.Mediator.Queries.AuthorQueries;

namespace RoesteRentACar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AuthorList()
        {
            var values = await _mediator.Send(new GetAuthorQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            var value = await _mediator.Send(new GetAuthorByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthor(AddAuthorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yazar başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            await _mediator.Send(new DeleteAuthorCommand(id));
            return Ok("Yazar başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yazar başarıyla güncellendi.");
        }
    }
}
