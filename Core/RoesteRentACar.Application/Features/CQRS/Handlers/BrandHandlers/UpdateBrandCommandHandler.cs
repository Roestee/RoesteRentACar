using RoesteRentACar.Application.Features.CQRS.Commands.BrandCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBrandCommand command)
        {
            var brand = await _repository.GetByIdAsync(command.Id);
            brand.Name = command.Name;

            await _repository.UpdateAsync(brand);
        }
    }
}
