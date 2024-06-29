namespace RoesteRentACar.Application.Features.CQRS.Commands.BannerCommands
{
    public class DeleteBannerCommand
    {
        public DeleteBannerCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
