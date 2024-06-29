namespace RoesteRentACar.Application.Features.CQRS.Commands.BrandCommands
{
    public class DeleteBrandCommand
    {
        public DeleteBrandCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
