using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class DeleteTestimonialCommand: IRequest
    {
        public DeleteTestimonialCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
