using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class DeleteSocialMediaCommand: IRequest
    {
        public DeleteSocialMediaCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
