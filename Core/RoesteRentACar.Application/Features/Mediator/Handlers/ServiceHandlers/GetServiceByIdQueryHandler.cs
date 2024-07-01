﻿using MediatR;
using RoesteRentACar.Application.Features.Mediator.Queries.ServiceQueries;
using RoesteRentACar.Application.Features.Mediator.Results.ServiceResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler: IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return new GetServiceByIdQueryResult
            {
                Id = value.Id,
                Title = value.Title,
                Description = value.Description,
                IconUrl = value.IconUrl
            };
        }
    }
}