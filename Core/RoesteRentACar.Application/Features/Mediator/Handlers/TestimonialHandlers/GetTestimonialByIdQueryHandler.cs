using MediatR;
using RoesteRentACar.Application.Features.Mediator.Queries.TestimonialQueries;
using RoesteRentACar.Application.Features.Mediator.Results.TestimonialResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler: IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return new GetTestimonialByIdQueryResult
            {
                Id = value.Id,
                Title = value.Title,
                Name = value.Name,
                Comment = value.Comment,
                ImageUrl = value.ImageUrl
            };
        }
    }
}
