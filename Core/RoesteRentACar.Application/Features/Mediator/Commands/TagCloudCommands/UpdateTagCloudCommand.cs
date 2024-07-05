using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class UpdateTagCloudCommand: IRequest
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
    }
}
