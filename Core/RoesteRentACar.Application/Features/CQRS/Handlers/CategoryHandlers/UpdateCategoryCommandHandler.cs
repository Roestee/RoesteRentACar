using RoesteRentACar.Application.Features.CQRS.Commands.CategoryCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
            
        public async Task Handle(UpdateCategoryCommand command)
        {
            var category = await _repository.GetByIdAsync(command.Id);
            category.Name = command.Name;

            await _repository.UpdateAsync(category);
        }
    }
}
