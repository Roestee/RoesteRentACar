using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class AddTestimonialCommand: IRequest
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
