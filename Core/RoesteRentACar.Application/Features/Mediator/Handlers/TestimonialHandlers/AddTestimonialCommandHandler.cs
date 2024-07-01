using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.TestimonialCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class AddTestimonialCommandHandler: IRequestHandler<AddTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public AddTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Testimonial
            {
                Title = request.Title,
                Name = request.Name,
                Comment = request.Comment,
                ImageUrl = request.ImageUrl
            }, cancellationToken);
        }
    }
}
