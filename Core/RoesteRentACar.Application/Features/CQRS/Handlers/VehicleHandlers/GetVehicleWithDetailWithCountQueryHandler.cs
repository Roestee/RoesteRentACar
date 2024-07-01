﻿using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.CQRS.Results.VehicleResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.VehicleHandlers
{
    public class GetVehicleWithDetailWithCountQueryHandler
    {
        private readonly IRepository<Vehicle> _repository;

        public GetVehicleWithDetailWithCountQueryHandler(IRepository<Vehicle> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetVehicleCarWithDetailWithCountQueryResult>> Handle(int count)
        {
            return await _repository.GetAllQueryable()
                .Include(x=>x.Brand)
                .OrderByDescending(x=>x.Id)
                .Take(count)
                .Select(x=> new GetVehicleCarWithDetailWithCountQueryResult
                {
                    Id = x.Id,
                    Model = x.Model,
                    CoverImageUrl = x.CoverImageUrl,
                    BrandName = x.Brand.Name,
                    BigImageUrl = x.BigImageUrl,
                    BrandId = x.BrandId,
                    Fuel = x.Fuel,
                    Km = x.Km,
                    Luggage = x.Luggage,
                    Seat = x.Seat,
                    Transmission = x.Transmission
                }).ToListAsync();
        }
    }
}