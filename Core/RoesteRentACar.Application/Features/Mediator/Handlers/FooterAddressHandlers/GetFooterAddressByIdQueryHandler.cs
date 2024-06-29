using MediatR;
using RoesteRentACar.Application.Features.Mediator.Queries.FooterAddressQueries;
using RoesteRentACar.Application.Features.Mediator.Results.FooterAddressResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return new GetFooterAddressByIdQueryResult
            {
                Id = value.Id,
                Description = value.Description,
                Email = value.Email,
                Address = value.Address,
                Phone = value.Phone
            };
        }
    }
}
