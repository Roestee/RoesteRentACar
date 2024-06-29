using RoesteRentACar.Application.Features.CQRS.Commands.CategoryCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class AddCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public AddCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddCategoryCommand command)
        {
            await _repository.AddAsync(new Category { Name = command.Name });
        }
    }
}
