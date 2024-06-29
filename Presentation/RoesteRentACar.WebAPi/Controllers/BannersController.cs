using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.CQRS.Commands.BannerCommands;
using RoesteRentACar.Application.Features.CQRS.Handlers.BannerHandlers;
using RoesteRentACar.Application.Features.CQRS.Queries.BannerQueries;

namespace RoesteRentACar.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly GetBannerQueryHandler _getBannerQueryHandler;
        private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;
        private readonly AddBannerCommandHandler _addBannerCommandHandler;
        private readonly DeleteBannerCommandHandler _deleteBannerCommandHandler;
        private readonly UpdateBannerCommandHandler _updateBannerCommandHandler;

        public BannersController(
            GetBannerQueryHandler getBannerQueryHandler, 
            GetBannerByIdQueryHandler getBannerByIdQueryHandler, 
            AddBannerCommandHandler addBannerCommandHandler, 
            DeleteBannerCommandHandler deleteBannerCommandHandler, 
            UpdateBannerCommandHandler updateBannerCommandHandler)
        {
            _getBannerQueryHandler = getBannerQueryHandler;
            _getBannerByIdQueryHandler = getBannerByIdQueryHandler;
            _addBannerCommandHandler = addBannerCommandHandler;
            _deleteBannerCommandHandler = deleteBannerCommandHandler;
            _updateBannerCommandHandler = updateBannerCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BannerList()
        {
            var values = await _getBannerQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner(int id)
        {
            var value = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddBanner(AddBannerCommand command)
        {
            await _addBannerCommandHandler.Handle(command);
            return Ok("Banner başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBanner(int id)
        {
            await _deleteBannerCommandHandler.Handle(new DeleteBannerCommand(id));
            return Ok("Banner başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
        {
            await _updateBannerCommandHandler.Handle(command);
            return Ok("Banner başarıyla güncellendi.");
        }
    }
}
