using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.PricingResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
    {
  
    }
}
