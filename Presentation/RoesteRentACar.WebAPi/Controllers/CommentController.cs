using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.Mediator.Commands.CommentCommands;
using RoesteRentACar.Application.Features.Mediator.Queries.CommentQueries;

namespace RoesteRentACar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CommentList()
        {
            var values = await _mediator.Send(new GetCommentQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            var value = await _mediator.Send(new GetCommentByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(AddCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteComment(int id)
        {
            await _mediator.Send(new DeleteCommentCommand(id));
            return Ok("Yorum başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum başarıyla güncellendi.");
        }
    }
}
