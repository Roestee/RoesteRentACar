using Microsoft.AspNetCore.Mvc;
using RoesteRentACar.Application.Features.CQRS.Commands.VehicleCommands;
using RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers;
using RoesteRentACar.Application.Features.CQRS.Queries.VehicleQueries;

namespace RoesteRentACar.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly GetVehicleQueryHandler _getVehicleQueryHandler;
        private readonly GetVehicleWithDetailQueryHandler _getVehicleWithDetailQueryHandler;
        private readonly GetVehicleWithDetailWithCountQueryHandler _getVehicleWithDetailWithCountQueryHandler;
        private readonly GetVehicleByIdQueryHandler _getVehicleByIdQueryHandler;
        private readonly AddVehicleCommandHandler _addVehicleCommandHandler;
        private readonly DeleteVehicleCommandHandler _deleteVehicleCommandHandler;
        private readonly UpdateVehicleCommandHandler _updateVehicleCommandHandler;

        public VehiclesController(
            GetVehicleQueryHandler getVehicleQueryHandler,
            GetVehicleWithDetailQueryHandler getVehicleWithDetailQueryHandler,
            GetVehicleWithDetailWithCountQueryHandler getVehicleWithDetailWithCountQueryHandler,
            GetVehicleByIdQueryHandler getVehicleByIdQueryHandler, 
            AddVehicleCommandHandler addVehicleCommandHandler,
            DeleteVehicleCommandHandler deleteVehicleCommandHandler,
            UpdateVehicleCommandHandler updateVehicleCommandHandler)
        {
            _getVehicleQueryHandler = getVehicleQueryHandler;
            _getVehicleWithDetailQueryHandler = getVehicleWithDetailQueryHandler;
            _getVehicleWithDetailWithCountQueryHandler = getVehicleWithDetailWithCountQueryHandler;
            _getVehicleByIdQueryHandler = getVehicleByIdQueryHandler;
            _addVehicleCommandHandler = addVehicleCommandHandler;
            _deleteVehicleCommandHandler = deleteVehicleCommandHandler;
            _updateVehicleCommandHandler = updateVehicleCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> VehicleList()
        {
            var values = await _getVehicleQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("VehicleListWithDetail")]
        public async Task<IActionResult> VehicleListWithDetail()
        {
            var values = await _getVehicleWithDetailQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("VehicleListWithDetailWithCount")]
        public async Task<IActionResult> VehicleListWithDetailWithCount(int count)
        {
            var values = await _getVehicleWithDetailWithCountQueryHandler.Handle(count);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var value = await _getVehicleByIdQueryHandler.Handle(new GetVehicleByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddVehicle(AddVehicleCommand command)
        {
            await _addVehicleCommandHandler.Handle(command);
            return Ok("Araç başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            await _deleteVehicleCommandHandler.Handle(new DeleteVehicleCommand(id));
            return Ok("Araç başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateVehicle(UpdateVehicleCommand command)
        {
            await _updateVehicleCommandHandler.Handle(command);
            return Ok("Araç başarıyla güncellendi.");
        }
    }
}
