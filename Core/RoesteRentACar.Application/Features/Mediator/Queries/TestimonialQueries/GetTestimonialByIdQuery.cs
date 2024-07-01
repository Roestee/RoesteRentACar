using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.TestimonialResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery: IRequest<GetTestimonialByIdQueryResult>
    {
        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
