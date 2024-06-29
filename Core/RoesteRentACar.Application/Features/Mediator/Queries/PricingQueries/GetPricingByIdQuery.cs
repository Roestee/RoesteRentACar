using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.PricingResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery: IRequest<GetPricingByIdQueryResult>
    {
        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
