using RoesteRentACar.Application.Features.CQRS.Commands.BrandCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class AddBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public AddBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddBrandCommand command)
        {
            await _repository.AddAsync(new Brand { Name = command.Name });
        }
    }
}
