using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class DeleteTagCloudCommand: IRequest
    {
        public DeleteTagCloudCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
