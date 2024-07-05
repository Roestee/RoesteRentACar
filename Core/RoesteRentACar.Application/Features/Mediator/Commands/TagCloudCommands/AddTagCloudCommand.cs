using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class AddTagCloudCommand: IRequest
    {
        public int BlogId { get; set; }
        public int Title { get; set; }
    }
}
