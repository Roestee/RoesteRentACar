using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.TagCloudCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class AddTagCloudCommandHandler: IRequestHandler<AddTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public AddTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddTagCloudCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new TagCloud
            {
                BlogId = request.BlogId,
                Title = request.Title
            }, cancellationToken);
        }
    }
}
