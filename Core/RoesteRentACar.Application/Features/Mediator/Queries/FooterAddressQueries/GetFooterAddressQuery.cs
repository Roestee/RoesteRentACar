using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.FooterAddressResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
    {

    }
}
