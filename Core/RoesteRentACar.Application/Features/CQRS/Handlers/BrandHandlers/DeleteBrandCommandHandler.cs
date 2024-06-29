using RoesteRentACar.Application.Features.CQRS.Commands.BrandCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class DeleteBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public DeleteBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBrandCommand command)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(command.Id));
        }
    }
}
