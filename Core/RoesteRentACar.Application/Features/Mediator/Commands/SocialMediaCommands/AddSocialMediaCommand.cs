using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class AddSocialMediaCommand: IRequest
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
