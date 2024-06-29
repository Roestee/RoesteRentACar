using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.Mediator.Commands.SocialMediaCommands;
using RoesteRentACar.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace RoesteRentACar.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocialMediasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> SocialMediaList()
        {
            var values = await _mediator.Send(new GetSocialMediaQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddSocialMedia(AddSocialMediaCommand command)
        {
            await _mediator.Send(command);
            return Ok("Sosyal medya başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            await _mediator.Send(new DeleteSocialMediaCommand(id));
            return Ok("Sosyal medya başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command)
        {
            await _mediator.Send(command);
            return Ok("Sosyal medya başarıyla güncellendi.");
        }
    }
}
