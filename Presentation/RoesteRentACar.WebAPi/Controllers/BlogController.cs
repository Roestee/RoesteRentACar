using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.Mediator.Commands.BlogCommands;
using RoesteRentACar.Application.Features.Mediator.Queries.BlogQueries;

namespace RoesteRentACar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }

        [HttpGet("BlogListWithDetail")]
        public async Task<IActionResult> BlogListWithDetail()
        {
            var values = await _mediator.Send(new GetBlogWithDetailQuery());
            return Ok(values);
        }

        [HttpGet("BlogListWithDetailWithCount")]
        public async Task<IActionResult> BlogListWithDetailWithCount(int count)
        {
            var values = await _mediator.Send(new GetBlogWithDetailWithCountQuery(count));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog(AddBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _mediator.Send(new DeleteBlogCommand(id));
            return Ok("Blog başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog başarıyla güncellendi.");
        }
    }
}
