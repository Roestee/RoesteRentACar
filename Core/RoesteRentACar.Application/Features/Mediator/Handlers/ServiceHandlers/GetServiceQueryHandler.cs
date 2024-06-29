using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.Mediator.Queries.ServiceQueries;
using RoesteRentACar.Application.Features.Mediator.Results.ServiceResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler: IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllQueryable()
                .Select(x => new GetServiceQueryResult
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    IconUrl = x.IconUrl
                }).ToListAsync(cancellationToken);
        }
    }
}
