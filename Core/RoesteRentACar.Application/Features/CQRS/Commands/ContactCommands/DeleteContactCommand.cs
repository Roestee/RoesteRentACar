namespace RoesteRentACar.Application.Features.CQRS.Commands.ContactCommands
{
    public class DeleteContactCommand
    {
        public DeleteContactCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
