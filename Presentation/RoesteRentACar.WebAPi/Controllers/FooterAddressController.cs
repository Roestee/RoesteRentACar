using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.Mediator.Commands.FooterAddressCommands;
using RoesteRentACar.Application.Features.Mediator.Queries.FooterAddressQueries;

namespace RoesteRentACar.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> FooterAddressList()
        {
            var values = await _mediator.Send(new GetFooterAddressQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAddress(int id)
        {
            var value = await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddFooterAddress(AddFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Footer adresi başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFooterAddress(int id)
        {
            await _mediator.Send(new DeleteFooterAddressCommand(id));
            return Ok("Footer adresi başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Footer adiresi başarıyla güncellendi.");
        }
    }
}
