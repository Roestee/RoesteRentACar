using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Features.CQRS.Results.ContactResults;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactQueryResult>> Handle()
        {
            return await _repository.GetAllQueryable()
                .Select(x => new GetContactQueryResult
                {
                    Id = x.Id,
                    Email = x.Email,
                    Message = x.Message,
                    Name = x.Name,
                    SendDate = x.SendDate,
                    Subject = x.Subject
                }).ToListAsync();
        }
    }
}
