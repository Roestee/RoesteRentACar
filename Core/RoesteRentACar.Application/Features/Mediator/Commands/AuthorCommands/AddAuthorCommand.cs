using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.AuthorCommands
{
    public class AddAuthorCommand: IRequest
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
