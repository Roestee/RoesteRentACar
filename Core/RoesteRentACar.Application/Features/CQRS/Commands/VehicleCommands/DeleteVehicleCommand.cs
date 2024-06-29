namespace RoesteRentACar.Application.Features.CQRS.Commands.VehicleCommands
{
    public class DeleteVehicleCommand
    {
        public DeleteVehicleCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
