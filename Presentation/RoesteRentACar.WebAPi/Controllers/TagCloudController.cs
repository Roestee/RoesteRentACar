using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.Mediator.Commands.TagCloudCommands;
using RoesteRentACar.Application.Features.Mediator.Queries.TagCloudQueries;

namespace RoesteRentACar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagCloudController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            var values = await _mediator.Send(new GetTagCloudQuery());
            return Ok(values);
        }

        [HttpGet("GetTagCloudsByBlogId")]
        public async Task<IActionResult> GetTagCloudsByBlogId(int blogId)
        {
            var values = await _mediator.Send(new GetTagCloudsByBlogIdQuery(blogId));
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloud(int id)
        {
            var value = await _mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddTagCloud(AddTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket bulutu başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTagCloud(int id)
        {
            await _mediator.Send(new DeleteTagCloudCommand(id));
            return Ok("Etiket bulutu başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket bulutu başarıyla güncellendi.");
        }
    }
}
