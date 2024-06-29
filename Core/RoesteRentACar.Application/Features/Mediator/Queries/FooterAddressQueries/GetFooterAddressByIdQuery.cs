using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.FooterAddressResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIdQuery: IRequest<GetFooterAddressByIdQueryResult>
    {
        public GetFooterAddressByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
