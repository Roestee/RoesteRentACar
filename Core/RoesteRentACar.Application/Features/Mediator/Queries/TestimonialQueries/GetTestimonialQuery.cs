using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.TestimonialResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
