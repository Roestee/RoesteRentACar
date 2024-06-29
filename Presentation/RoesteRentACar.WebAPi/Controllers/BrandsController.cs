using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.CQRS.Commands.BrandCommands;
using RoesteRentACar.Application.Features.CQRS.Handlers.BrandHandlers;
using RoesteRentACar.Application.Features.CQRS.Queries.BrandQueries;
using RoesteRentACar.Application.Features.CQRS.Results.BrandResults;

namespace RoesteRentACar.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly GetBrandQueryHandler _brandQueryHandler;
        private readonly GetBrandByIdQueryHandler _brandByIdQueryHandler;
        private readonly AddBrandCommandHandler _addBrandCommandHandler;
        private readonly DeleteBrandCommandHandler _deleteBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;

        public BrandsController(GetBrandQueryHandler brandQueryHandler, 
            GetBrandByIdQueryHandler brandByIdQueryHandler, 
            AddBrandCommandHandler addBrandCommandHandler,
            DeleteBrandCommandHandler deleteBrandCommandHandler,
            UpdateBrandCommandHandler updateBrandCommandHandler)
        {
            _brandQueryHandler = brandQueryHandler;
            _brandByIdQueryHandler = brandByIdQueryHandler;
            _addBrandCommandHandler = addBrandCommandHandler;
            _deleteBrandCommandHandler = deleteBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var values = await _brandQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var value = await _brandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddBrand(AddBrandCommand command)
        {
            await _addBrandCommandHandler.Handle(command);
            return Ok("Marka başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _deleteBrandCommandHandler.Handle(new DeleteBrandCommand(id));
            return Ok("Marka başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _updateBrandCommandHandler.Handle(command);
            return Ok("Marka başarıyla güncellendi.");
        }
    }
}
