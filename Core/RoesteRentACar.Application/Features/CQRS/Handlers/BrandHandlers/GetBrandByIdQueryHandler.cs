﻿using RoesteRentACar.Application.Features.CQRS.Queries.BrandQueries;
using RoesteRentACar.Application.Features.CQRS.Results.BrandResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}
