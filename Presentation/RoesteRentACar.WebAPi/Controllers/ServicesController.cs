using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.Mediator.Commands.ServiceCommands;
using RoesteRentACar.Application.Features.Mediator.Queries.ServiceQueries;

namespace RoesteRentACar.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _mediator.Send(new GetServiceQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _mediator.Send(new GetServiceByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddService(AddServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hizmet başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _mediator.Send(new DeleteServiceCommand(id));
            return Ok("Hizmet başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hizmet başarıyla eklendi.");
        }
    }
}
