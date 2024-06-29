using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.CQRS.Results.CategoryResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            return await _repository.GetAllQueryable()
                .Select(x => new GetCategoryQueryResult
            {
                    Id = x.Id,
                    Name = x.Name
            }).ToListAsync();
        }
    }
}
