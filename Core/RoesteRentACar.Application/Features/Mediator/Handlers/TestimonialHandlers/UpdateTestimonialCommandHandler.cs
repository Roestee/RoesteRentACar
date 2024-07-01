using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.TestimonialCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler: IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var testimonial = await _repository.GetByIdAsync(request.Id, cancellationToken);
            testimonial.Name = request.Name;
            testimonial.Comment = request.Comment;
            testimonial.Title = request.Title;
            testimonial.ImageUrl = request.ImageUrl;

            await _repository.UpdateAsync(testimonial, cancellationToken);
        }
    }
}
